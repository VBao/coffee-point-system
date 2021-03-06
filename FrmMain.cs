using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace customer
{
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "CommentTypo")]
    public partial class FrmMain : Form
    {
        private readonly ChangeView _cv = new ChangeView();

        private DataTable _customerDt;
        private DataView _gvCus;

        //  Set up CUSTOMER ADAPTER and DATATABLE
        private readonly CoffeePJDataSet.customerInformationDataTable _customerInformationDt =
            new CoffeePJDataSet.customerInformationDataTable();

        private readonly CoffeePJDataSetTableAdapters.customerInformationTableAdapter _customerInformationAdapter =
            new CoffeePJDataSetTableAdapters.customerInformationTableAdapter();

        //  Set up PURCHASED ADAPTER and DATATABLE
        private readonly CoffeePJDataSet.purchasedHistoryDataTable _purchasedHistoryDt =
            new CoffeePJDataSet.purchasedHistoryDataTable();


        private readonly CoffeePJDataSetTableAdapters.purchasedHistoryTableAdapter _purchasedHistoryAdapter =
            new CoffeePJDataSetTableAdapters.purchasedHistoryTableAdapter();

        // Set up ClosedXML to export to excel
        private XLWorkbook _wb;

        public FrmMain()
        {
            InitializeComponent();
        }

        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        private void Load_Data()
        {
            try
            {
                _purchasedHistoryAdapter.Fill(_purchasedHistoryDt);
                _customerInformationAdapter.Fill(_customerInformationDt);
                _customerDt = _customerInformationDt.CopyToDataTable();
                _gvCus = _customerDt.DefaultView;
                gvCustomers.DataSource = _gvCus;
                gvCustomers.DataSource = _customerDt;

                gvCustomers.Columns["id"].HeaderText = @"ID";
                gvCustomers.Columns["name"].HeaderText = @"Tên";
                // gvCustomers.Columns["phone"].HeaderText = @"SĐT";
                gvCustomers.Columns["phone"].Visible = false;
                gvCustomers.Columns["point"].HeaderText = @"Điểm";
                gvCustomers.Columns["gender"].Visible = false;
                gvCustomers.Columns["spendTotal"].Visible = false;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message + @"\n" + ex.Source);
                Load_Data();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Load_Data();
            }
            catch (Exception eLoad)
            {
                if (!(eLoad is InvalidOperationException))
                {
                    MessageBox.Show(eLoad.Message + @"\n" + eLoad.Source);
                }
            }
        }

        private void gvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PurchasedShowData();
            txtITel.Enabled = false;
            txtIName.Enabled = false;
            // txtSearch.Text = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtIId.Enabled = false;
            txtIName.Enabled = false;
            if (txtSearch.Text != null)
            {
                Regex re = new Regex(@"([a-zA-Z]+)(\d+)");
                Match result = re.Match(txtSearch.Text);
                // _gvCus.RowFilter = "id LIKE '" + txtSearch.Text + "%'";
                _gvCus.RowFilter = "id LIKE '%" + result.Groups[2].Value + "%'" +
                                   "and id LIKE '" + result.Groups[1].Value + "%'";
                if (txtSearch.Text.Count(c => Char.IsDigit(c)) == 3)
                {
                    for (int i = 0; i < _gvCus.Count; i++)
                    {
                        string id = _gvCus[i]["id"].ToString();
                        if (id.Count(x => Char.IsDigit(x)) != 3 && _gvCus.Count != 1)
                        {
                            MessageBox.Show(@"Có khách hàng có id đặc biệt");
                            break;
                        }
                    }
                }

                if (_gvCus.Count == 1)
                {
                    PurchasedShowData();
                }
            }
            else
            {
                _gvCus = _customerDt.DefaultView;
            }
        }

        // When "xóa" button clicked
        private void btnClear_Click(object sender, EventArgs e)
        {
            lbIErr.Text = "";
            txtSearch.Text = null;
        }

        // ReSharper disable once CommentTypo
        // When "Cập nhật" button clicked
        private void btnPurchased_Click(object sender, EventArgs e)
        {
            string SetId(int len)
            {
                string id = txtIName.Text.Trim().Split(' ').Last().ToUpper() +
                            txtITel.Text.Substring(txtITel.Text.Length - len);
                return id;
            }

            void Purchased(Int16[] cupIo)
            {
                _cv.ChangeErrNot(lbIPrice, false);
                _purchasedHistoryAdapter.Fill(_purchasedHistoryDt);
                DataRow infoRow = _customerInformationDt.FirstOrDefault(b => b.id.Equals(txtIId.Text));
                DataRow purchasedRow = _purchasedHistoryDt.NewRow();
                //Create new purchased Record
                purchasedRow[1] = txtIId.Text;
                if (cupIo[1] == 0)
                    // purchasedRow[2] = cupIO[0] < 0 ? cupIO[0] * 10 : cupIO[0];
                    purchasedRow[2] = cupIo[0];
                else
                {
                    DataRow purchaseRow1 = _purchasedHistoryDt.NewRow();
                    purchaseRow1[1] = txtIId.Text;
                    purchaseRow1[2] = cupIo[0];
                    purchaseRow1[3] = DateTime.Now;
                    purchaseRow1[4] = 1;
                    _purchasedHistoryDt.Rows.Add(purchaseRow1);
                    purchasedRow[2] = cupIo[1];
                }

                purchasedRow[3] = DateTime.Now;
                purchasedRow[4] = 1;
                _purchasedHistoryDt.Rows.Add(purchasedRow);
                _purchasedHistoryAdapter.Update(_purchasedHistoryDt);


                // Check if name changed to update to database
                string check;
                if (txtIName.Enabled)
                {
                    check = "Đổi tên từ: " + infoRow.Field<String>("name") + "\nSang: " + txtIName.Text;
                    if (MessageBox.Show(check, @"Đổi tên", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        infoRow["name"] = txtIName.Text.ToUpper();
                    }
                }

                if (txtITel.Enabled)
                {
                    check = "Đổi SĐT từ: " + infoRow.Field<String>("phone") + "\nSang: " + txtITel.Text;
                    if (MessageBox.Show(check, @"Đổi số điện thoại", MessageBoxButtons.YesNo) ==
                        DialogResult.Yes)
                    {
                        infoRow["phone"] = txtITel.Text;
                    }
                }

                void CreatId(int temptLen)
                {
                    try
                    {
                        infoRow["id"] = SetId(temptLen);
                    }
                    catch (ConstraintException)
                    {
                        temptLen++;
                        CreatId(temptLen);
                    }


                }

                if (txtIName.Enabled || txtITel.Enabled) { 
                    CreatId(3);
                    MessageBox.Show(@"Id của khách hàng là: " + infoRow["id"]);
                }
                _customerInformationAdapter.Update(infoRow);
                txtITel.Enabled = false;
                txtIName.Enabled = false;

                if (cupIo[1] == 0)
                {
                    infoRow["point"] = cupIo[0] < 0
                        ? cupIo[0] * 10 + Convert.ToInt32(txtIPoint.Text)
                        : cupIo[0] + Convert.ToInt32(txtIPoint.Text);
                }
                else
                {
                    infoRow["point"] = cupIo[0] * 10 + cupIo[1] + Convert.ToInt16(txtIPoint.Text);
                }

                _customerInformationAdapter.Update(_customerInformationDt);

                txtSearch.Text = null;
                Load_Data();
                ResetTab();
            }

            // if (txtIId.Text == "") throw new UserException("Vui lòng chọn Id");
            if (txtIId.Text == "") Invoke(new Action(() => throw new UserException("Vui lòng chọn Id")));
            Int16[] cup = new Int16[2];
            if (txtICup.Text.Contains("/"))
            {
                cup[0] = Int16.Parse(txtICup.Text.Split('/')[0]);
                cup[1] = Int16.Parse(txtICup.Text.Split('/')[1]);
                Purchased(cup);
            }
            else if (Int16.TryParse(txtICup.Text, out cup[0]))
            {
                Purchased(cup);
            }
            else
            {
                if (txtICup.Text == "")
                {
                    _cv.ChangeErrNot(lbIPrice, true);
                    throw new UserException(@"Vui lòng nhập số ly");
                }

                _cv.ChangeErrNot(lbIPrice, true);
                throw new UserException(@"Số ly chỉ nhận số");
            }
        }

        private void txtCAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCName.Text) &&
                String.IsNullOrEmpty(txtCCup.Text) &&
                String.IsNullOrEmpty(txtCTel.Text) &&
                String.IsNullOrEmpty(txtCCup.Text))
            {
                if (String.IsNullOrEmpty(txtCName.Text)) lbCName.ForeColor = Color.Red;
                if (String.IsNullOrEmpty(txtCTel.Text)) lbCTel.ForeColor = Color.Red;
                if (String.IsNullOrEmpty(txtCCup.Text)) lbCPoint.ForeColor = Color.Red;
            }
            else
            {
                if (!Regex.IsMatch(txtCTel.Text, "^[0]+\\d{9}$"))
                {
                    lbCTel.ForeColor = Color.Red;
                    throw new UserException("SĐT không đúng");
                }

                // DataRow infoRow = _customerInformationDt.NewRow();
                //string name = txtCName.Text.Trim();

                string CreateId(int temptLen)
                {
                    string ids = txtCName.Text.Trim().Split(' ').Last().ToUpper() +
                                 txtCTel.Text.Substring(txtCTel.Text.Length - temptLen);
                    return ids;
                }

                int totalSpend = Convert.ToInt32(txtCCup.Text);
                if (!Int16.TryParse(txtCCup.Text, out Int16 cup)) throw new UserException("Số lượng không hợp lệ");

                string CreatCustomer(int tempLen)
                {
                    try
                    {
                        _customerInformationDt.AddcustomerInformationRow(CreateId(tempLen), txtCName.Text, _gender,
                            txtCTel.Text, cup,
                            totalSpend);
                    }
                    catch (ConstraintException)
                    {
                        tempLen++;
                        CreatCustomer(tempLen);
                    }

                    return CreateId(tempLen);
                }

                string id = CreatCustomer(3);
                _purchasedHistoryDt.AddpurchasedHistoryRow(id, cup, DateTime.Now, 1);
                _customerInformationAdapter.Update(_customerInformationDt);
                _purchasedHistoryAdapter.Update(_purchasedHistoryDt);
                MessageBox.Show(@"Id của khách hàng là: " + id);
                Load_Data();
                ResetTab();
            }
        }


        DataTable ConvertToDataTable<TSource>(IEnumerable<TSource> source)
        {
            var props = typeof(TSource).GetProperties();

            var dt = new DataTable();
            dt.Columns.AddRange(
                props.Select(p => new DataColumn(p.Name, p.PropertyType)).ToArray()
            );

            source.ToList().ForEach(
                i => dt.Rows.Add(props.Select(p => p.GetValue(i, null)).ToArray())
            );
            return dt;
        }

        private bool _gender;

        private void btnFemale_Click(object sender, EventArgs e)
        {
            btnFemale.BackColor = Color.Aquamarine;
            btnMale.BackColor = default;
            _gender = false;
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            btnMale.BackColor = Color.Aquamarine;
            btnFemale.BackColor = default;
            _gender = true;
        }

        private void PurchasedShowData()
        {
            int row = gvCustomers.CurrentCell.RowIndex;
            tbCustomer.SelectedIndex = 0;
            txtIId.Text = gvCustomers.Rows[row].Cells["id"].Value.ToString();
            txtIName.Text = gvCustomers.Rows[row].Cells["name"].Value.ToString();
            txtITel.Text = gvCustomers.Rows[row].Cells["phone"].Value.ToString();
            txtIPoint.Text = gvCustomers.Rows[row].Cells["point"].Value.ToString();
            if (Convert.ToInt32(gvCustomers.Rows[row].Cells["point"].Value) / 10 > 0)
                lbIErr.Text = @"Có thể đổi " + Convert.ToInt32(gvCustomers.Rows[row].Cells["point"].Value) / 10 +
                              @" ly";
            else
                lbIErr.Text = "";
            txtICup.Enabled = true;
        }

        private void ResetTab()
        {
            lbCName.ForeColor = default;
            lbCTel.ForeColor = default;
            lbCPoint.ForeColor = default;
            txtCName.Text = "";
            txtCTel.Text = "";
            txtCCup.Text = "";
            tbCustomer.SelectTab(0);
            btnFemale.BackColor = default;
            btnMale.BackColor = default;
            txtICup.Enabled = false;
            txtIId.Text = "";
            txtIName.Text = "";
            txtIPoint.Text = "";
            txtITel.Text = "";
            txtICup.Text = "";
            lbIErr.Text = "";
        }

        private void lbIName_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIName.Text)) txtIName.Enabled = true;
        }

        private void lbIPhone_DoubleClick(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtITel.Text)) txtITel.Enabled = true;
        }

        private void btnDayExport_Click(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            try
            {
                _wb = new XLWorkbook();
                // MessageBox.Show(dtStart.Value.Date + "|||" + dtEnd.Value.Date.AddHours(23.999)); // Test line
                var data = (
                    from p in _purchasedHistoryDt
                    join c in _customerInformationDt on p.customerId equals c.id
                    where p.paidDate == date.Date &&
                          p.paidAmount < 0
                    select new
                    {
                        ID = c.id,
                        Tên = c.name,
                        SĐT = c.phone,
                        Đổi = p.paidAmount * -1,
                        Món = "",
                        Giá = "",
                        // Điểm = p.paidAmount
                    });
                DataTable payment = ConvertToDataTable(data);
                _wb.AddWorksheet(payment, "Tổng kết");
                // _wb.AddWorksheet(_customerDt, "Khách");
                var exportDialog = new SaveFileDialog
                {
                    FileName = @"TổngKết",
                    Filter = @"Excel files|*.xlsx",
                    Title = @"Save an Excel File"
                };
                exportDialog.ShowDialog();
                if (!String.IsNullOrWhiteSpace(exportDialog.FileName)) _wb.SaveAs(exportDialog.FileName);
            }
            catch (UserException exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void btnMonthExport_Click(object sender, EventArgs e)
        {
            var date = DateTime.Today;
            string temp = DateTime.Now.Year + "/" + DateTime.Now.Month + "/01";
            var first = DateTime.Parse(temp);
            try
            {
                _wb = new XLWorkbook();
                // MessageBox.Show(dtStart.Value.Date + "|||" + dtEnd.Value.Date.AddHours(23.999)); // Test line
                var data = (
                    from p in _purchasedHistoryDt
                    join c in _customerInformationDt on p.customerId equals c.id
                    where p.paidDate <= date.Date &&
                          p.paidDate >= first.Date &&
                          p.paidAmount < 0
                    select new
                    {
                        ID = c.id,
                        Tên = c.name,
                        SĐT = c.phone,
                        Đổi = p.paidAmount * -1,
                        Món = "",
                        Giá = "",
                        // Điểm = p.paidAmount
                    });
                DataTable payment = ConvertToDataTable(data);
                _wb.AddWorksheet(payment, "Tổng kết");
                // _wb.AddWorksheet(_customerDt, "Khách");
                var exportDialog = new SaveFileDialog
                {
                    FileName = @"TổngKết",
                    Filter = @"Excel files|*.xlsx",
                    Title = @"Save an Excel File"
                };
                exportDialog.ShowDialog();
                if (!String.IsNullOrWhiteSpace(exportDialog.FileName)) _wb.SaveAs(exportDialog.FileName);
            }
            catch (UserException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
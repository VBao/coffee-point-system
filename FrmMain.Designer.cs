
namespace customer
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCName = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.tbCustomer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtICup = new System.Windows.Forms.TextBox();
            this.lbIErr = new System.Windows.Forms.Label();
            this.txtIPoint = new System.Windows.Forms.TextBox();
            this.txtITel = new System.Windows.Forms.TextBox();
            this.txtIName = new System.Windows.Forms.TextBox();
            this.txtIId = new System.Windows.Forms.TextBox();
            this.btnPurchased = new System.Windows.Forms.Button();
            this.lbIPrice = new System.Windows.Forms.Label();
            this.lbIPoint = new System.Windows.Forms.Label();
            this.lbIPhone = new System.Windows.Forms.Label();
            this.lbIName = new System.Windows.Forms.Label();
            this.lbIID = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dobDate = new System.Windows.Forms.TextBox();
            this.txtCCup = new System.Windows.Forms.TextBox();
            this.lbCPoint = new System.Windows.Forms.Label();
            this.lbCDob = new System.Windows.Forms.Label();
            this.lbCGender = new System.Windows.Forms.Label();
            this.txtCAdd = new System.Windows.Forms.Button();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.lbCTel = new System.Windows.Forms.Label();
            this.pGen = new System.Windows.Forms.Panel();
            this.btnMale = new System.Windows.Forms.Button();
            this.btnFemale = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.gvCustomers = new System.Windows.Forms.DataGridView();
            this.btnSClear = new System.Windows.Forms.Button();
            this.coffeePJDataSet = new customer.CoffeePJDataSet();
            this.tbCustomer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pGen.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeePJDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtSearch.Location = new System.Drawing.Point(191, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 45);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // lbCName
            // 
            this.lbCName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCName.AutoSize = true;
            this.lbCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCName.Location = new System.Drawing.Point(76, 25);
            this.lbCName.Name = "lbCName";
            this.lbCName.Size = new System.Drawing.Size(63, 29);
            this.lbCName.TabIndex = 3;
            this.lbCName.Text = "Tên:";
            // 
            // txtCName
            // 
            this.txtCName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCName.Location = new System.Drawing.Point(167, 22);
            this.txtCName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(404, 45);
            this.txtCName.TabIndex = 2;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Controls.Add(this.tabPage1);
            this.tbCustomer.Controls.Add(this.tabPage2);
            this.tbCustomer.Controls.Add(this.tabPage3);
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.tbCustomer.Location = new System.Drawing.Point(639, 11);
            this.tbCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.SelectedIndex = 0;
            this.tbCustomer.Size = new System.Drawing.Size(608, 452);
            this.tbCustomer.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtICup);
            this.tabPage1.Controls.Add(this.lbIErr);
            this.tabPage1.Controls.Add(this.txtIPoint);
            this.tabPage1.Controls.Add(this.txtITel);
            this.tabPage1.Controls.Add(this.txtIName);
            this.tabPage1.Controls.Add(this.txtIId);
            this.tabPage1.Controls.Add(this.btnPurchased);
            this.tabPage1.Controls.Add(this.lbIPrice);
            this.tabPage1.Controls.Add(this.lbIPoint);
            this.tabPage1.Controls.Add(this.lbIPhone);
            this.tabPage1.Controls.Add(this.lbIName);
            this.tabPage1.Controls.Add(this.lbIID);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tabPage1.Location = new System.Drawing.Point(4, 47);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(600, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tích điểm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtICup
            // 
            this.txtICup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtICup.Location = new System.Drawing.Point(160, 263);
            this.txtICup.Margin = new System.Windows.Forms.Padding(4);
            this.txtICup.Name = "txtICup";
            this.txtICup.Size = new System.Drawing.Size(391, 45);
            this.txtICup.TabIndex = 14;
            // 
            // lbIErr
            // 
            this.lbIErr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIErr.AutoSize = true;
            this.lbIErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIErr.ForeColor = System.Drawing.Color.Red;
            this.lbIErr.Location = new System.Drawing.Point(5, 351);
            this.lbIErr.Name = "lbIErr";
            this.lbIErr.Size = new System.Drawing.Size(0, 29);
            this.lbIErr.TabIndex = 13;
            // 
            // txtIPoint
            // 
            this.txtIPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIPoint.Enabled = false;
            this.txtIPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtIPoint.Location = new System.Drawing.Point(160, 202);
            this.txtIPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIPoint.Name = "txtIPoint";
            this.txtIPoint.Size = new System.Drawing.Size(391, 45);
            this.txtIPoint.TabIndex = 4;
            // 
            // txtITel
            // 
            this.txtITel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtITel.Enabled = false;
            this.txtITel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtITel.Location = new System.Drawing.Point(160, 137);
            this.txtITel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtITel.Name = "txtITel";
            this.txtITel.Size = new System.Drawing.Size(391, 45);
            this.txtITel.TabIndex = 3;
            // 
            // txtIName
            // 
            this.txtIName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIName.Enabled = false;
            this.txtIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtIName.Location = new System.Drawing.Point(160, 70);
            this.txtIName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIName.Name = "txtIName";
            this.txtIName.Size = new System.Drawing.Size(391, 45);
            this.txtIName.TabIndex = 2;
            // 
            // txtIId
            // 
            this.txtIId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIId.Enabled = false;
            this.txtIId.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtIId.Location = new System.Drawing.Point(160, 6);
            this.txtIId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIId.Name = "txtIId";
            this.txtIId.Size = new System.Drawing.Size(391, 45);
            this.txtIId.TabIndex = 1;
            // 
            // btnPurchased
            // 
            this.btnPurchased.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnPurchased.Location = new System.Drawing.Point(283, 334);
            this.btnPurchased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPurchased.Name = "btnPurchased";
            this.btnPurchased.Size = new System.Drawing.Size(268, 62);
            this.btnPurchased.TabIndex = 8;
            this.btnPurchased.Text = "Cập nhật";
            this.btnPurchased.UseVisualStyleBackColor = true;
            this.btnPurchased.Click += new System.EventHandler(this.btnPurchased_Click);
            // 
            // lbIPrice
            // 
            this.lbIPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIPrice.AutoSize = true;
            this.lbIPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbIPrice.Location = new System.Drawing.Point(3, 274);
            this.lbIPrice.Name = "lbIPrice";
            this.lbIPrice.Size = new System.Drawing.Size(127, 29);
            this.lbIPrice.TabIndex = 5;
            this.lbIPrice.Text = "Số lượng: ";
            // 
            // lbIPoint
            // 
            this.lbIPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIPoint.AutoSize = true;
            this.lbIPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIPoint.Location = new System.Drawing.Point(47, 212);
            this.lbIPoint.Name = "lbIPoint";
            this.lbIPoint.Size = new System.Drawing.Size(80, 29);
            this.lbIPoint.TabIndex = 5;
            this.lbIPoint.Text = "Điểm:";
            // 
            // lbIPhone
            // 
            this.lbIPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIPhone.AutoSize = true;
            this.lbIPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIPhone.Location = new System.Drawing.Point(52, 148);
            this.lbIPhone.Name = "lbIPhone";
            this.lbIPhone.Size = new System.Drawing.Size(70, 29);
            this.lbIPhone.TabIndex = 5;
            this.lbIPhone.Text = "SĐT:";
            this.lbIPhone.DoubleClick += new System.EventHandler(this.lbIPhone_DoubleClick);
            // 
            // lbIName
            // 
            this.lbIName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIName.AutoSize = true;
            this.lbIName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIName.Location = new System.Drawing.Point(64, 80);
            this.lbIName.Name = "lbIName";
            this.lbIName.Size = new System.Drawing.Size(63, 29);
            this.lbIName.TabIndex = 5;
            this.lbIName.Text = "Tên:";
            this.lbIName.DoubleClick += new System.EventHandler(this.lbIName_DoubleClick);
            // 
            // lbIID
            // 
            this.lbIID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIID.AutoSize = true;
            this.lbIID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbIID.Location = new System.Drawing.Point(89, 16);
            this.lbIID.Name = "lbIID";
            this.lbIID.Size = new System.Drawing.Size(47, 29);
            this.lbIID.TabIndex = 5;
            this.lbIID.Text = "Id: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dobDate);
            this.tabPage2.Controls.Add(this.txtCCup);
            this.tabPage2.Controls.Add(this.lbCPoint);
            this.tabPage2.Controls.Add(this.lbCDob);
            this.tabPage2.Controls.Add(this.lbCGender);
            this.tabPage2.Controls.Add(this.txtCAdd);
            this.tabPage2.Controls.Add(this.txtCTel);
            this.tabPage2.Controls.Add(this.lbCTel);
            this.tabPage2.Controls.Add(this.txtCName);
            this.tabPage2.Controls.Add(this.lbCName);
            this.tabPage2.Controls.Add(this.pGen);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.tabPage2.Location = new System.Drawing.Point(4, 47);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(600, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tạo thành viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dobDate
            // 
            this.dobDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dobDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.dobDate.Location = new System.Drawing.Point(167, 210);
            this.dobDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dobDate.Name = "dobDate";
            this.dobDate.Size = new System.Drawing.Size(404, 45);
            this.dobDate.TabIndex = 5;
            // 
            // txtCCup
            // 
            this.txtCCup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCCup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCCup.Location = new System.Drawing.Point(167, 271);
            this.txtCCup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCCup.Name = "txtCCup";
            this.txtCCup.Size = new System.Drawing.Size(404, 45);
            this.txtCCup.TabIndex = 6;
            // 
            // lbCPoint
            // 
            this.lbCPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCPoint.AutoSize = true;
            this.lbCPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCPoint.Location = new System.Drawing.Point(16, 282);
            this.lbCPoint.Name = "lbCPoint";
            this.lbCPoint.Size = new System.Drawing.Size(120, 29);
            this.lbCPoint.TabIndex = 15;
            this.lbCPoint.Text = "Số lượng:";
            // 
            // lbCDob
            // 
            this.lbCDob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCDob.AutoSize = true;
            this.lbCDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCDob.Location = new System.Drawing.Point(11, 220);
            this.lbCDob.Name = "lbCDob";
            this.lbCDob.Size = new System.Drawing.Size(128, 29);
            this.lbCDob.TabIndex = 13;
            this.lbCDob.Text = "Năm sinh:";
            // 
            // lbCGender
            // 
            this.lbCGender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCGender.AutoSize = true;
            this.lbCGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCGender.Location = new System.Drawing.Point(27, 94);
            this.lbCGender.Name = "lbCGender";
            this.lbCGender.Size = new System.Drawing.Size(113, 29);
            this.lbCGender.TabIndex = 7;
            this.lbCGender.Text = "Giới tính:";
            // 
            // txtCAdd
            // 
            this.txtCAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCAdd.Location = new System.Drawing.Point(368, 322);
            this.txtCAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCAdd.Name = "txtCAdd";
            this.txtCAdd.Size = new System.Drawing.Size(204, 62);
            this.txtCAdd.TabIndex = 7;
            this.txtCAdd.Text = "Tạo";
            this.txtCAdd.UseVisualStyleBackColor = true;
            this.txtCAdd.Click += new System.EventHandler(this.txtCAdd_Click);
            // 
            // txtCTel
            // 
            this.txtCTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtCTel.Location = new System.Drawing.Point(167, 146);
            this.txtCTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(404, 45);
            this.txtCTel.TabIndex = 4;
            // 
            // lbCTel
            // 
            this.lbCTel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCTel.AutoSize = true;
            this.lbCTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbCTel.Location = new System.Drawing.Point(65, 158);
            this.lbCTel.Name = "lbCTel";
            this.lbCTel.Size = new System.Drawing.Size(70, 29);
            this.lbCTel.TabIndex = 5;
            this.lbCTel.Text = "SĐT:";
            // 
            // pGen
            // 
            this.pGen.Controls.Add(this.btnMale);
            this.pGen.Controls.Add(this.btnFemale);
            this.pGen.Location = new System.Drawing.Point(167, 71);
            this.pGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pGen.Name = "pGen";
            this.pGen.Size = new System.Drawing.Size(405, 70);
            this.pGen.TabIndex = 3;
            // 
            // btnMale
            // 
            this.btnMale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMale.Location = new System.Drawing.Point(252, 10);
            this.btnMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(121, 50);
            this.btnMale.TabIndex = 15;
            this.btnMale.Text = "Nam";
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // btnFemale
            // 
            this.btnFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnFemale.Location = new System.Drawing.Point(44, 10);
            this.btnFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(121, 50);
            this.btnFemale.TabIndex = 14;
            this.btnFemale.Text = "Nữ";
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtEnd);
            this.tabPage3.Controls.Add(this.dtStart);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.btnExport);
            this.tabPage3.Location = new System.Drawing.Point(4, 47);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(600, 401);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Xuất";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/MM/yyyy";
            this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(153, 130);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(432, 36);
            this.dtEnd.TabIndex = 11;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd/MM/yyyy";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(153, 46);
            this.dtStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(432, 36);
            this.dtStart.TabIndex = 10;
            this.dtStart.Value = new System.DateTime(2021, 2, 21, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(11, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 29);
            this.label13.TabIndex = 9;
            this.label13.Text = "Kết thúc:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(16, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 29);
            this.label12.TabIndex = 8;
            this.label12.Text = "Bắt đầu:";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnExport.Location = new System.Drawing.Point(153, 316);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(195, 62);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gvCustomers
            // 
            this.gvCustomers.AllowUserToAddRows = false;
            this.gvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCustomers.Location = new System.Drawing.Point(12, 80);
            this.gvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.RowHeadersVisible = false;
            this.gvCustomers.RowHeadersWidth = 20;
            this.gvCustomers.RowTemplate.Height = 40;
            this.gvCustomers.Size = new System.Drawing.Size(621, 383);
            this.gvCustomers.TabIndex = 2;
            this.gvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCustomers_CellClick);
            // 
            // btnSClear
            // 
            this.btnSClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSClear.Location = new System.Drawing.Point(525, 14);
            this.btnSClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(108, 62);
            this.btnSClear.TabIndex = 8;
            this.btnSClear.Text = "Xóa";
            this.btnSClear.UseVisualStyleBackColor = true;
            this.btnSClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // coffeePJDataSet
            // 
            this.coffeePJDataSet.DataSetName = "CoffeePJDataSet";
            this.coffeePJDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1255, 484);
            this.Controls.Add(this.btnSClear);
            this.Controls.Add(this.gvCustomers);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tbCustomer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pGen.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeePJDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TabControl tbCustomer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button txtCAdd;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Label lbCTel;
        private System.Windows.Forms.DataGridView gvCustomers;
        private System.Windows.Forms.TextBox txtIPoint;
        private System.Windows.Forms.TextBox txtITel;
        private System.Windows.Forms.TextBox txtIName;
        private System.Windows.Forms.TextBox txtIId;
        private System.Windows.Forms.Button btnPurchased;
        private System.Windows.Forms.Label lbIPrice;
        private System.Windows.Forms.Label lbIPoint;
        private System.Windows.Forms.Label lbIPhone;
        private System.Windows.Forms.Label lbIName;
        private System.Windows.Forms.Label lbIID;
        private System.Windows.Forms.Button btnSClear;
        private CoffeePJDataSet coffeePJDataSet;
        private System.Windows.Forms.Label lbCGender;
        private System.Windows.Forms.Panel pGen;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.TextBox txtCCup;
        private System.Windows.Forms.Label lbCPoint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lbIErr;
        private System.Windows.Forms.TextBox txtICup;
        private System.Windows.Forms.TextBox dobDate;
        private System.Windows.Forms.Label lbCDob;
    }
}


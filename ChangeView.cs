using System.Drawing;
using System.Windows.Forms;

namespace customer
{
    public class ChangeView
    {
        public void ChangeErrNot(Label lb,bool error)
        {
            if (error)
            {
                lb.ForeColor=Color.Red;
            }
            else
            {
                lb.ForeColor=Color.Black;
            }
        }
    }
}
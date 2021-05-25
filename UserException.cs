using System;
// using System.Windows.Forms;

namespace customer
{
    public class UserException:Exception
    {
        public UserException(string msg) : base(msg)
        {
            // MessageBox.Show(msg);
        }
    }
}
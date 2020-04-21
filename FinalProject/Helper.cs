using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Helper
    {
        public static void showMessageBox(string text,
                                          string title)
        {
            MessageBox.Show(text,
                            title,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);
        }
    }
}

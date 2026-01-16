using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDCS
{
    public partial class uc_cd_thongso_malt : UserControl
    {
        public uc_cd_thongso_malt()
        {
            InitializeComponent();
        }

        private void uc_cd_thongso_malt_Load(object sender, EventArgs e)
        {
            txtkpmalt.Text = Program.kp_malt.ToString();
            txtkimalt.Text = Program.ki_malt.ToString();
            txtkdmalt.Text = Program.kd_malt.ToString();
            txtmaxmalt.Text = Program.max_malt.ToString();
            txtminmalt.Text = Program.min_malt.ToString();
        }
    }
}

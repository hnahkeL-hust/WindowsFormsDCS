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
    public partial class uc_cd_thongso_hoa : UserControl
    {
        public uc_cd_thongso_hoa()
        {
            InitializeComponent();
        }

        private void uc_cd_thongso_hoa_Load(object sender, EventArgs e)
        {
            txtkphoa.Text = Program.kp_hoa.ToString();
            txtkihoa.Text = Program.ki_hoa.ToString();
            txtkdhoa.Text = Program.kd_hoa.ToString();
            txtmaxhoa.Text = Program.max_hoa.ToString();
            txtminhoa.Text = Program.min_hoa.ToString();
        }
    }
}

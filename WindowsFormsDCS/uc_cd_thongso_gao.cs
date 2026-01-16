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
    public partial class uc_cd_thongso_gao : UserControl
    {
        public uc_cd_thongso_gao()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnluunoigao_Click(object sender, EventArgs e)
        {

        }

        private void uc_cd_thongso_gao_Load(object sender, EventArgs e)
        {
            txtkpgao.Text = Program.kp_gao.ToString();
            txtkigao.Text = Program.ki_gao.ToString();
            txtkdgao.Text = Program.kd_gao.ToString();
            txtmaxgao.Text = Program.max_gao.ToString();
            txtmingao.Text = Program.min_gao.ToString();
        }
    }
}

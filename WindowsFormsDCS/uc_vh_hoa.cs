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
    public partial class uc_vh_hoa : UserControl
    {
        public uc_vh_hoa()
        {
            InitializeComponent();
        }

        private void uc_vh_hoa_Load(object sender, EventArgs e)
        {
            txtnhietdonoihoa.Text = Program.nhietdonoihoa.ToString();
        }
    }
}

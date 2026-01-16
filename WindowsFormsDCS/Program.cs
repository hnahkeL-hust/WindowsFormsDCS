using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDCS
{
    internal static class Program
    {
        public static string LoaiTaiKhoan = "";

        public static float nhietdonoigao = 0.0f;
        public static float nhietdonoimalt = 0.0f;
        public static float nhietdonoihoa = 0.0f;
        public static float kp_gao = 0.0f;
        public static float ki_gao = 0.0f;
        public static float kd_gao = 0.0f;
        public static float max_gao = 0.0f;
        public static float min_gao = 0.0f;
        public static float kp_malt = 0.0f;
        public static float ki_malt = 0.0f;
        public static float kd_malt = 0.0f;
        public static float max_malt = 0.0f;
        public static float min_malt = 0.0f;
        public static float kp_hoa = 0.0f;
        public static float ki_hoa = 0.0f;
        public static float kd_hoa = 0.0f;
        public static float max_hoa = 0.0f;
        public static float min_hoa = 0.0f;
        public static float diachiip = 0.0f;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //Application.Run(new frm_trangchinh());

            frm_dangnhap frmLogin = new frm_dangnhap();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frm_trangchinh());
            }
            else
            {
                Application.Exit();
            }
            
        }
    }
}

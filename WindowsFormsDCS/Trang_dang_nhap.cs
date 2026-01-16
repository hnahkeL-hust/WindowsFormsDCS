using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsDCS
{
    public partial class frm_dangnhap : Form
    {
        //string strConnect = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=SCADA_Bia;Integrated Security=True";
        string strConnect = ConfigurationManager.ConnectionStrings["SCADA_Conn"].ConnectionString;
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConnect))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT QuyenHan FROM TaiKhoan WHERE TenDangNhap = @user AND MatKhau = @pass";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", txttaikhoan.Text);
                    cmd.Parameters.AddWithValue("@pass", txtmatkhau.Text);

                    object ketQua = cmd.ExecuteScalar();

                    if (ketQua != null) // Đăng nhập đúng
                    {
                        // Lưu quyền vào biến toàn cục để dùng sau này
                        Program.LoaiTaiKhoan = ketQua.ToString();

                        this.DialogResult = DialogResult.OK; // Báo OK để mở form chính
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi kết nối: " ); }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtmatkhau.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}

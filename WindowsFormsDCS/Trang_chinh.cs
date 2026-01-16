using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
enum CheDo { VanHanh, CaiDat, BaoCao }
enum KhuVuc { Gao,Malt, Loc, Hoa ,Lang }

namespace WindowsFormsDCS
{
    public partial class frm_trangchinh : Form
    {
        CheDo cheDoHienTai = CheDo.VanHanh;
        KhuVuc khuVucHienTai = KhuVuc.Gao;
        public frm_trangchinh()
        {
            InitializeComponent();
        }
        private void frm_trangchinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?",
            "Xác nhận thoát",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        // Hàm này giúp bật/tắt nhanh các nút hàng trên
        private void CauHinhMenuTren(bool hiengao, bool hienmalt, bool hienhoa, bool hienloc, bool hienlang)
        {
            btnnoigao.Enabled = hiengao;
            btnnoimalt.Enabled = hienmalt;
            btnnoiloc.Enabled = hienhoa;
            btnnoihoa.Enabled = hienloc;
            btnnoilang.Enabled = hienlang;
        }
        private void btnnoigao_Click(object sender, EventArgs e)
        {
            khuVucHienTai = KhuVuc.Gao;
            CapNhatGiaoDien();
        }

        private void CapNhatGiaoDien()
        {
            UserControl ucCanHienThi = null;
            switch (cheDoHienTai)
            {
                case CheDo.VanHanh:
                    // Yêu cầu: Hiện hết 5 nút
                    CauHinhMenuTren(true, true, true, true, true);
                    break;

                case CheDo.CaiDat:
                    // Yêu cầu: Chỉ hiện 3 nút (Gạo, Malt, Hoa) - Ẩn Lọc, Lắng
                    CauHinhMenuTren(true, true, false, true, false);
                    break;

                case CheDo.BaoCao:
                    // Yêu cầu: Không hiện nút nào
                    CauHinhMenuTren(false, false, false, false, false);
                    break;
            }
            // Xử lý Logic Ma trận
            switch (cheDoHienTai)
            {
                case CheDo.VanHanh:
                    if (khuVucHienTai == KhuVuc.Gao) ucCanHienThi = new uc_vh_gao();
                    else if (khuVucHienTai == KhuVuc.Loc) ucCanHienThi = new uc_vh_loc();
                    else if (khuVucHienTai == KhuVuc.Hoa) ucCanHienThi = new uc_vh_hoa();
                    else if (khuVucHienTai == KhuVuc.Malt) ucCanHienThi = new uc_vh_malt();
                    else if (khuVucHienTai == KhuVuc.Lang) ucCanHienThi = new uc_vh_lang();
                    break;

                case CheDo.CaiDat:
                    if (khuVucHienTai == KhuVuc.Gao) ucCanHienThi = new uc_cd_thongso_gao();
                    else if (khuVucHienTai == KhuVuc.Malt) ucCanHienThi = new uc_cd_thongso_malt();
                    else if (khuVucHienTai == KhuVuc.Hoa) ucCanHienThi = new uc_cd_thongso_hoa();
                    else
                    {
                        // Lỡ đang ở Nồi Lọc mà bấm sang Cài Đặt (Nồi Lọc bị ẩn) -> Tự nhảy về Nồi Gạo
                        khuVucHienTai = KhuVuc.Gao;
                        ucCanHienThi = new uc_cd_thongso_gao();
                    }
                    break;

                case CheDo.BaoCao:
                    ucCanHienThi = new uc_bc();
                    break;
            }

            // Hiển thị lên Panel (như mình đã hướng dẫn trước đó)
            if (ucCanHienThi != null)
            {
                pnluc.Controls.Clear();
                ucCanHienThi.Dock = DockStyle.Fill;
                pnluc.Controls.Add(ucCanHienThi);
            }

            // Mẹo nhỏ: Đổi màu nút bấm để biết đang chọn cái nào (Highlight)
            //
        }

        private void btnvanhanh_Click(object sender, EventArgs e)
        {
            cheDoHienTai = CheDo.VanHanh;
            CapNhatGiaoDien();
        }
        private void btncaidat_Click(object sender, EventArgs e)
        {
            cheDoHienTai = CheDo.CaiDat;
            CapNhatGiaoDien();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            cheDoHienTai = CheDo.BaoCao;
            CapNhatGiaoDien();
        }

        private void btnnoimalt_Click(object sender, EventArgs e)
        {
            khuVucHienTai = KhuVuc.Malt;
            CapNhatGiaoDien();
        }

        private void btnnoiloc_Click(object sender, EventArgs e)
        {
            khuVucHienTai = KhuVuc.Loc;
            CapNhatGiaoDien();
        }

        private void btnnoihoa_Click(object sender, EventArgs e)
        {
            khuVucHienTai = KhuVuc.Hoa;
            CapNhatGiaoDien();
        }

        private void btnnoilang_Click(object sender, EventArgs e)
        {
            khuVucHienTai = KhuVuc.Lang;
            CapNhatGiaoDien();
        }

        private void frm_trangchinh_Load(object sender, EventArgs e)
        {
            txtdiachiip.Text = Program.diachiip.ToString();

            // ---PHẦN 1: PHÂN QUYỀN ẨN / HIỆN NÚT-- -

            // Trường hợp 1: Nếu là OPERATOR
            if (Program.LoaiTaiKhoan == "operator")
            {
                // Yêu cầu: Ẩn nút Cài đặt
                btncaidat.Enabled = false;

                // Mặc định vào là thấy màn hình Vận hành luôn (OK)
                cheDoHienTai = CheDo.VanHanh;
            }
            // Trường hợp 2: Nếu là ADMIN
            else if (Program.LoaiTaiKhoan == "admin")
            {
                // Yêu cầu: Ẩn nút Vận hành
                btnvanhanh.Enabled = false;

                // QUAN TRỌNG: Vì nút Vận hành bị ẩn, ta không thể để màn hình mặc định là Vận hành được
                // Phải ép chuyển ngay sang màn hình Cài đặt hoặc Báo cáo
                cheDoHienTai = CheDo.CaiDat;
            }

            // --- PHẦN 2: LOAD GIAO DIỆN LẦN ĐẦU ---
            // Gọi hàm cập nhật để nó vẽ đúng màn hình theo chế độ vừa set ở trên
            CapNhatGiaoDien();
        }

        private void btnketnoi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
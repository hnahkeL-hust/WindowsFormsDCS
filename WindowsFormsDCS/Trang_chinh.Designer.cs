namespace WindowsFormsDCS
{
    partial class frm_trangchinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpchucnang = new System.Windows.Forms.TableLayoutPanel();
            this.btnvanhanh = new System.Windows.Forms.Button();
            this.btncaidat = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            this.pnlketnoi = new System.Windows.Forms.Panel();
            this.txtdiachiip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnketnoi = new System.Windows.Forms.Button();
            this.tlpnoi = new System.Windows.Forms.TableLayoutPanel();
            this.btnnoilang = new System.Windows.Forms.Button();
            this.btnnoihoa = new System.Windows.Forms.Button();
            this.btnnoiloc = new System.Windows.Forms.Button();
            this.btnnoimalt = new System.Windows.Forms.Button();
            this.btnnoigao = new System.Windows.Forms.Button();
            this.pnluc = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpchucnang.SuspendLayout();
            this.pnlketnoi.SuspendLayout();
            this.tlpnoi.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpchucnang
            // 
            this.tlpchucnang.ColumnCount = 1;
            this.tlpchucnang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpchucnang.Controls.Add(this.btnvanhanh, 0, 1);
            this.tlpchucnang.Controls.Add(this.btncaidat, 0, 2);
            this.tlpchucnang.Controls.Add(this.btnbaocao, 0, 3);
            this.tlpchucnang.Controls.Add(this.pnlketnoi, 0, 0);
            this.tlpchucnang.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlpchucnang.Location = new System.Drawing.Point(0, 0);
            this.tlpchucnang.Name = "tlpchucnang";
            this.tlpchucnang.RowCount = 6;
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.22625F));
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.77375F));
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlpchucnang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tlpchucnang.Size = new System.Drawing.Size(159, 611);
            this.tlpchucnang.TabIndex = 0;
            // 
            // btnvanhanh
            // 
            this.btnvanhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvanhanh.Location = new System.Drawing.Point(3, 162);
            this.btnvanhanh.Name = "btnvanhanh";
            this.btnvanhanh.Size = new System.Drawing.Size(124, 63);
            this.btnvanhanh.TabIndex = 0;
            this.btnvanhanh.Text = "Vận hành";
            this.btnvanhanh.UseVisualStyleBackColor = true;
            this.btnvanhanh.Click += new System.EventHandler(this.btnvanhanh_Click);
            // 
            // btncaidat
            // 
            this.btncaidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaidat.Location = new System.Drawing.Point(3, 319);
            this.btncaidat.Name = "btncaidat";
            this.btncaidat.Size = new System.Drawing.Size(124, 59);
            this.btncaidat.TabIndex = 1;
            this.btncaidat.Text = "Cài đặt";
            this.btncaidat.UseVisualStyleBackColor = true;
            this.btncaidat.Click += new System.EventHandler(this.btncaidat_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbaocao.Location = new System.Drawing.Point(3, 454);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(124, 58);
            this.btnbaocao.TabIndex = 2;
            this.btnbaocao.Text = "Báo cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // pnlketnoi
            // 
            this.pnlketnoi.Controls.Add(this.txtdiachiip);
            this.pnlketnoi.Controls.Add(this.label1);
            this.pnlketnoi.Controls.Add(this.btnketnoi);
            this.pnlketnoi.Location = new System.Drawing.Point(3, 3);
            this.pnlketnoi.Name = "pnlketnoi";
            this.pnlketnoi.Size = new System.Drawing.Size(150, 153);
            this.pnlketnoi.TabIndex = 3;
            // 
            // txtdiachiip
            // 
            this.txtdiachiip.Location = new System.Drawing.Point(9, 33);
            this.txtdiachiip.Name = "txtdiachiip";
            this.txtdiachiip.Size = new System.Drawing.Size(100, 20);
            this.txtdiachiip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Địa chỉ IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnketnoi
            // 
            this.btnketnoi.Location = new System.Drawing.Point(12, 59);
            this.btnketnoi.Name = "btnketnoi";
            this.btnketnoi.Size = new System.Drawing.Size(97, 32);
            this.btnketnoi.TabIndex = 0;
            this.btnketnoi.Text = "Kết nối";
            this.btnketnoi.UseVisualStyleBackColor = true;
            this.btnketnoi.Click += new System.EventHandler(this.btnketnoi_Click);
            // 
            // tlpnoi
            // 
            this.tlpnoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpnoi.ColumnCount = 5;
            this.tlpnoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnoi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpnoi.Controls.Add(this.btnnoilang, 4, 0);
            this.tlpnoi.Controls.Add(this.btnnoihoa, 3, 0);
            this.tlpnoi.Controls.Add(this.btnnoiloc, 2, 0);
            this.tlpnoi.Controls.Add(this.btnnoimalt, 1, 0);
            this.tlpnoi.Controls.Add(this.btnnoigao, 0, 0);
            this.tlpnoi.Location = new System.Drawing.Point(3, 3);
            this.tlpnoi.Name = "tlpnoi";
            this.tlpnoi.RowCount = 1;
            this.tlpnoi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnoi.Size = new System.Drawing.Size(1080, 53);
            this.tlpnoi.TabIndex = 1;
            // 
            // btnnoilang
            // 
            this.btnnoilang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoilang.Location = new System.Drawing.Point(867, 3);
            this.btnnoilang.Name = "btnnoilang";
            this.btnnoilang.Size = new System.Drawing.Size(210, 46);
            this.btnnoilang.TabIndex = 4;
            this.btnnoilang.Text = "Nồi lắng xoáy";
            this.btnnoilang.UseVisualStyleBackColor = true;
            this.btnnoilang.Click += new System.EventHandler(this.btnnoilang_Click);
            // 
            // btnnoihoa
            // 
            this.btnnoihoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoihoa.Location = new System.Drawing.Point(651, 3);
            this.btnnoihoa.Name = "btnnoihoa";
            this.btnnoihoa.Size = new System.Drawing.Size(210, 46);
            this.btnnoihoa.TabIndex = 3;
            this.btnnoihoa.Text = "Nồi hoa";
            this.btnnoihoa.UseVisualStyleBackColor = true;
            this.btnnoihoa.Click += new System.EventHandler(this.btnnoihoa_Click);
            // 
            // btnnoiloc
            // 
            this.btnnoiloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoiloc.Location = new System.Drawing.Point(435, 3);
            this.btnnoiloc.Name = "btnnoiloc";
            this.btnnoiloc.Size = new System.Drawing.Size(210, 46);
            this.btnnoiloc.TabIndex = 2;
            this.btnnoiloc.Text = "Nồi lọc";
            this.btnnoiloc.UseVisualStyleBackColor = true;
            this.btnnoiloc.Click += new System.EventHandler(this.btnnoiloc_Click);
            // 
            // btnnoimalt
            // 
            this.btnnoimalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoimalt.Location = new System.Drawing.Point(219, 3);
            this.btnnoimalt.Name = "btnnoimalt";
            this.btnnoimalt.Size = new System.Drawing.Size(210, 46);
            this.btnnoimalt.TabIndex = 1;
            this.btnnoimalt.Text = "Nồi malt";
            this.btnnoimalt.UseVisualStyleBackColor = true;
            this.btnnoimalt.Click += new System.EventHandler(this.btnnoimalt_Click);
            // 
            // btnnoigao
            // 
            this.btnnoigao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnoigao.Location = new System.Drawing.Point(3, 3);
            this.btnnoigao.Name = "btnnoigao";
            this.btnnoigao.Size = new System.Drawing.Size(210, 46);
            this.btnnoigao.TabIndex = 0;
            this.btnnoigao.Text = "Nồi gạo";
            this.btnnoigao.UseVisualStyleBackColor = true;
            this.btnnoigao.Click += new System.EventHandler(this.btnnoigao_Click);
            // 
            // pnluc
            // 
            this.pnluc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnluc.Location = new System.Drawing.Point(3, 63);
            this.pnluc.Name = "pnluc";
            this.pnluc.Size = new System.Drawing.Size(1080, 545);
            this.pnluc.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnluc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlpnoi, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.819967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.18003F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1086, 611);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // frm_trangchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 611);
            this.Controls.Add(this.tlpchucnang);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_trangchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nha may bia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_trangchinh_FormClosing);
            this.Load += new System.EventHandler(this.frm_trangchinh_Load);
            this.tlpchucnang.ResumeLayout(false);
            this.pnlketnoi.ResumeLayout(false);
            this.pnlketnoi.PerformLayout();
            this.tlpnoi.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpchucnang;
        private System.Windows.Forms.Button btnvanhanh;
        private System.Windows.Forms.Button btncaidat;
        private System.Windows.Forms.Button btnbaocao;
        private System.Windows.Forms.TableLayoutPanel tlpnoi;
        private System.Windows.Forms.Panel pnluc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnnoilang;
        private System.Windows.Forms.Button btnnoihoa;
        private System.Windows.Forms.Button btnnoiloc;
        private System.Windows.Forms.Button btnnoimalt;
        private System.Windows.Forms.Button btnnoigao;
        private System.Windows.Forms.Panel pnlketnoi;
        private System.Windows.Forms.Button btnketnoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdiachiip;
    }
}
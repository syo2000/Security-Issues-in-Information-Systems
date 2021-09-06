
namespace giaodien_phanhe2
{
    partial class Form_NVKETOAN
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_manv_nvkt = new System.Windows.Forms.TextBox();
            this.bt_Viewchamcong = new System.Windows.Forms.Button();
            this.dgv_chamcong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sua2 = new System.Windows.Forms.Button();
            this.tb_phucap_nvkt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_luongcoban_nvkt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_hoten_nvkt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.bt_viewnhanvien = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_vnv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nv";
            // 
            // tb_manv_nvkt
            // 
            this.tb_manv_nvkt.Location = new System.Drawing.Point(115, 32);
            this.tb_manv_nvkt.Name = "tb_manv_nvkt";
            this.tb_manv_nvkt.Size = new System.Drawing.Size(100, 22);
            this.tb_manv_nvkt.TabIndex = 1;
            // 
            // bt_Viewchamcong
            // 
            this.bt_Viewchamcong.Location = new System.Drawing.Point(467, 508);
            this.bt_Viewchamcong.Name = "bt_Viewchamcong";
            this.bt_Viewchamcong.Size = new System.Drawing.Size(96, 50);
            this.bt_Viewchamcong.TabIndex = 2;
            this.bt_Viewchamcong.Text = "View cham cong";
            this.bt_Viewchamcong.UseVisualStyleBackColor = true;
            this.bt_Viewchamcong.Click += new System.EventHandler(this.bt_Viewchamcong_Click_1);
            // 
            // dgv_chamcong
            // 
            this.dgv_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chamcong.Location = new System.Drawing.Point(443, 287);
            this.dgv_chamcong.Name = "dgv_chamcong";
            this.dgv_chamcong.RowHeadersWidth = 51;
            this.dgv_chamcong.RowTemplate.Height = 24;
            this.dgv_chamcong.Size = new System.Drawing.Size(345, 215);
            this.dgv_chamcong.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sua2);
            this.groupBox1.Controls.Add(this.tb_phucap_nvkt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_luongcoban_nvkt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_hoten_nvkt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_manv_nvkt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 242);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor";
            // 
            // bt_sua2
            // 
            this.bt_sua2.Location = new System.Drawing.Point(115, 195);
            this.bt_sua2.Name = "bt_sua2";
            this.bt_sua2.Size = new System.Drawing.Size(75, 41);
            this.bt_sua2.TabIndex = 7;
            this.bt_sua2.Text = "Update";
            this.bt_sua2.UseVisualStyleBackColor = true;
            this.bt_sua2.Click += new System.EventHandler(this.bt_sua2_Click);
            // 
            // tb_phucap_nvkt
            // 
            this.tb_phucap_nvkt.Location = new System.Drawing.Point(115, 158);
            this.tb_phucap_nvkt.Name = "tb_phucap_nvkt";
            this.tb_phucap_nvkt.Size = new System.Drawing.Size(100, 22);
            this.tb_phucap_nvkt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phụ cấp";
            // 
            // tb_luongcoban_nvkt
            // 
            this.tb_luongcoban_nvkt.Location = new System.Drawing.Point(115, 116);
            this.tb_luongcoban_nvkt.Name = "tb_luongcoban_nvkt";
            this.tb_luongcoban_nvkt.Size = new System.Drawing.Size(100, 22);
            this.tb_luongcoban_nvkt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lương cơ bản";
            // 
            // tb_hoten_nvkt
            // 
            this.tb_hoten_nvkt.Location = new System.Drawing.Point(115, 72);
            this.tb_hoten_nvkt.Name = "tb_hoten_nvkt";
            this.tb_hoten_nvkt.Size = new System.Drawing.Size(100, 22);
            this.tb_hoten_nvkt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // dgv_nhanvien
            // 
            this.dgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhanvien.Location = new System.Drawing.Point(12, 287);
            this.dgv_nhanvien.Name = "dgv_nhanvien";
            this.dgv_nhanvien.RowHeadersWidth = 51;
            this.dgv_nhanvien.RowTemplate.Height = 24;
            this.dgv_nhanvien.Size = new System.Drawing.Size(345, 215);
            this.dgv_nhanvien.TabIndex = 5;
            this.dgv_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nhanvien_CellContentClick_1);
            // 
            // bt_viewnhanvien
            // 
            this.bt_viewnhanvien.Location = new System.Drawing.Point(639, 508);
            this.bt_viewnhanvien.Name = "bt_viewnhanvien";
            this.bt_viewnhanvien.Size = new System.Drawing.Size(92, 50);
            this.bt_viewnhanvien.TabIndex = 2;
            this.bt_viewnhanvien.Text = "View luong";
            this.bt_viewnhanvien.UseVisualStyleBackColor = true;
            this.bt_viewnhanvien.Click += new System.EventHandler(this.bt_viewnhanvien_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(713, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 35);
            this.bt_back.TabIndex = 6;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Chấm công";
            // 
            // bt_vnv
            // 
            this.bt_vnv.Location = new System.Drawing.Point(121, 508);
            this.bt_vnv.Name = "bt_vnv";
            this.bt_vnv.Size = new System.Drawing.Size(82, 50);
            this.bt_vnv.TabIndex = 8;
            this.bt_vnv.Text = "View nhan vien";
            this.bt_vnv.UseVisualStyleBackColor = true;
            this.bt_vnv.Click += new System.EventHandler(this.bt_vnv_Click);
            // 
            // Form_NVKETOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 563);
            this.Controls.Add(this.bt_vnv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.dgv_nhanvien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_chamcong);
            this.Controls.Add(this.bt_viewnhanvien);
            this.Controls.Add(this.bt_Viewchamcong);
            this.Name = "Form_NVKETOAN";
            this.Text = "Form_NVKETOAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_manv_nvkt;
        private System.Windows.Forms.Button bt_Viewchamcong;
        private System.Windows.Forms.DataGridView dgv_chamcong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_nhanvien;
        private System.Windows.Forms.Button bt_viewnhanvien;
        private System.Windows.Forms.TextBox tb_phucap_nvkt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_luongcoban_nvkt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_hoten_nvkt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_sua2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_vnv;
    }
}

namespace giaodien_phanhe2
{
    partial class Form_TIEPTAN
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
            this.dgv_hsba = new System.Windows.Forms.DataGridView();
            this.dgv_hsdv = new System.Windows.Forms.DataGridView();
            this.dgv_hsbn = new System.Windows.Forms.DataGridView();
            this.bt_view_hsba = new System.Windows.Forms.Button();
            this.bt_viewhosodichvu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mabn = new System.Windows.Forms.TextBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ht = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ngaysinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbn)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hồ sơ dịch vụ";
            // 
            // dgv_hsba
            // 
            this.dgv_hsba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsba.Location = new System.Drawing.Point(12, 24);
            this.dgv_hsba.Name = "dgv_hsba";
            this.dgv_hsba.RowHeadersWidth = 51;
            this.dgv_hsba.RowTemplate.Height = 24;
            this.dgv_hsba.Size = new System.Drawing.Size(459, 205);
            this.dgv_hsba.TabIndex = 1;
            // 
            // dgv_hsdv
            // 
            this.dgv_hsdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsdv.Location = new System.Drawing.Point(12, 327);
            this.dgv_hsdv.Name = "dgv_hsdv";
            this.dgv_hsdv.RowHeadersWidth = 51;
            this.dgv_hsdv.RowTemplate.Height = 24;
            this.dgv_hsdv.Size = new System.Drawing.Size(459, 215);
            this.dgv_hsdv.TabIndex = 2;
            // 
            // dgv_hsbn
            // 
            this.dgv_hsbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsbn.Location = new System.Drawing.Point(502, 24);
            this.dgv_hsbn.Name = "dgv_hsbn";
            this.dgv_hsbn.RowHeadersWidth = 51;
            this.dgv_hsbn.RowTemplate.Height = 24;
            this.dgv_hsbn.Size = new System.Drawing.Size(378, 518);
            this.dgv_hsbn.TabIndex = 3;
            this.dgv_hsbn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hsbn_CellContentClick);
            // 
            // bt_view_hsba
            // 
            this.bt_view_hsba.Location = new System.Drawing.Point(194, 235);
            this.bt_view_hsba.Name = "bt_view_hsba";
            this.bt_view_hsba.Size = new System.Drawing.Size(108, 46);
            this.bt_view_hsba.TabIndex = 4;
            this.bt_view_hsba.Text = "View ho so benh an";
            this.bt_view_hsba.UseVisualStyleBackColor = true;
            this.bt_view_hsba.Click += new System.EventHandler(this.bt_view_hsba_Click);
            // 
            // bt_viewhosodichvu
            // 
            this.bt_viewhosodichvu.Location = new System.Drawing.Point(194, 548);
            this.bt_viewhosodichvu.Name = "bt_viewhosodichvu";
            this.bt_viewhosodichvu.Size = new System.Drawing.Size(108, 46);
            this.bt_viewhosodichvu.TabIndex = 5;
            this.bt_viewhosodichvu.Text = "View ho so dich vu";
            this.bt_viewhosodichvu.UseVisualStyleBackColor = true;
            this.bt_viewhosodichvu.Click += new System.EventHandler(this.bt_viewhosodichvu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hồ sơ bệnh án";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "View ho so benh nhan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hồ sơ bệnh nhân";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_insert);
            this.groupBox1.Controls.Add(this.bt_update);
            this.groupBox1.Controls.Add(this.tb_sdt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_diachi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_ngaysinh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_ht);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_mabn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(908, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 313);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor";
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(1085, 550);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 35);
            this.bt_back.TabIndex = 8;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã bệnh nhân";
            // 
            // tb_mabn
            // 
            this.tb_mabn.Location = new System.Drawing.Point(111, 34);
            this.tb_mabn.Name = "tb_mabn";
            this.tb_mabn.Size = new System.Drawing.Size(100, 22);
            this.tb_mabn.TabIndex = 1;
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(136, 244);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 43);
            this.bt_update.TabIndex = 2;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(20, 244);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(75, 43);
            this.bt_insert.TabIndex = 9;
            this.bt_insert.Text = "Insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // tb_ht
            // 
            this.tb_ht.Location = new System.Drawing.Point(111, 76);
            this.tb_ht.Name = "tb_ht";
            this.tb_ht.Size = new System.Drawing.Size(100, 22);
            this.tb_ht.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // tb_ngaysinh
            // 
            this.tb_ngaysinh.Location = new System.Drawing.Point(111, 120);
            this.tb_ngaysinh.Name = "tb_ngaysinh";
            this.tb_ngaysinh.Size = new System.Drawing.Size(100, 22);
            this.tb_ngaysinh.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // tb_diachi
            // 
            this.tb_diachi.Location = new System.Drawing.Point(111, 161);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.Size = new System.Drawing.Size(100, 22);
            this.tb_diachi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "SĐT";
            // 
            // tb_sdt
            // 
            this.tb_sdt.Location = new System.Drawing.Point(111, 202);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.Size = new System.Drawing.Size(100, 22);
            this.tb_sdt.TabIndex = 1;
            // 
            // Form_TIEPTAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 602);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_viewhosodichvu);
            this.Controls.Add(this.bt_view_hsba);
            this.Controls.Add(this.dgv_hsbn);
            this.Controls.Add(this.dgv_hsdv);
            this.Controls.Add(this.dgv_hsba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_TIEPTAN";
            this.Text = "Form_TIEPTAN";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbn)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hsba;
        private System.Windows.Forms.DataGridView dgv_hsdv;
        private System.Windows.Forms.DataGridView dgv_hsbn;
        private System.Windows.Forms.Button bt_view_hsba;
        private System.Windows.Forms.Button bt_viewhosodichvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox tb_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ht;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mabn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_insert;
    }
}
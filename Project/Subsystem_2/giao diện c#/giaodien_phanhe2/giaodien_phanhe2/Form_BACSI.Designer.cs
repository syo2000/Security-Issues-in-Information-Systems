
namespace giaodien_phanhe2
{
    partial class Form_BACSI
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
            this.bt_viewhsbenhan = new System.Windows.Forms.Button();
            this.dgv_hsbenhnhan = new System.Windows.Forms.DataGridView();
            this.dgv_hsdichvu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sua = new System.Windows.Forms.Button();
            this.tb_ketluan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nguoithuchien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_makhambenh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_back = new System.Windows.Forms.Button();
            this.bt_viewhsdv_bsi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_kb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nguoith = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ketluan1 = new System.Windows.Forms.TextBox();
            this.bt_update1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbenhnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsdichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_viewhsbenhan
            // 
            this.bt_viewhsbenhan.Location = new System.Drawing.Point(139, 462);
            this.bt_viewhsbenhan.Name = "bt_viewhsbenhan";
            this.bt_viewhsbenhan.Size = new System.Drawing.Size(91, 49);
            this.bt_viewhsbenhan.TabIndex = 2;
            this.bt_viewhsbenhan.Text = "View ho so benh an";
            this.bt_viewhsbenhan.UseVisualStyleBackColor = true;
            this.bt_viewhsbenhan.Click += new System.EventHandler(this.bt_viewhsbenhan_Click);
            // 
            // dgv_hsbenhnhan
            // 
            this.dgv_hsbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsbenhnhan.Location = new System.Drawing.Point(12, 257);
            this.dgv_hsbenhnhan.Name = "dgv_hsbenhnhan";
            this.dgv_hsbenhnhan.RowHeadersWidth = 51;
            this.dgv_hsbenhnhan.RowTemplate.Height = 24;
            this.dgv_hsbenhnhan.Size = new System.Drawing.Size(359, 197);
            this.dgv_hsbenhnhan.TabIndex = 3;
            this.dgv_hsbenhnhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hsbenhnhan_CellContentClick);
            // 
            // dgv_hsdichvu
            // 
            this.dgv_hsdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hsdichvu.Location = new System.Drawing.Point(410, 257);
            this.dgv_hsdichvu.Name = "dgv_hsdichvu";
            this.dgv_hsdichvu.RowHeadersWidth = 51;
            this.dgv_hsdichvu.RowTemplate.Height = 24;
            this.dgv_hsdichvu.Size = new System.Drawing.Size(368, 197);
            this.dgv_hsdichvu.TabIndex = 3;
            this.dgv_hsdichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hsdichvu_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sua);
            this.groupBox1.Controls.Add(this.tb_ketluan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nguoithuchien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_makhambenh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(410, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 200);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor_hosodichvu";
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(125, 148);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(102, 40);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Update";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // tb_ketluan
            // 
            this.tb_ketluan.Location = new System.Drawing.Point(127, 110);
            this.tb_ketluan.Name = "tb_ketluan";
            this.tb_ketluan.Size = new System.Drawing.Size(100, 22);
            this.tb_ketluan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết luận";
            // 
            // tb_nguoithuchien
            // 
            this.tb_nguoithuchien.Location = new System.Drawing.Point(127, 73);
            this.tb_nguoithuchien.Name = "tb_nguoithuchien";
            this.tb_nguoithuchien.Size = new System.Drawing.Size(100, 22);
            this.tb_nguoithuchien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người thực hiện";
            // 
            // tb_makhambenh
            // 
            this.tb_makhambenh.Location = new System.Drawing.Point(127, 35);
            this.tb_makhambenh.Name = "tb_makhambenh";
            this.tb_makhambenh.Size = new System.Drawing.Size(100, 22);
            this.tb_makhambenh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hồ sơ";
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(722, 8);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 36);
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // bt_viewhsdv_bsi
            // 
            this.bt_viewhsdv_bsi.Location = new System.Drawing.Point(564, 462);
            this.bt_viewhsdv_bsi.Name = "bt_viewhsdv_bsi";
            this.bt_viewhsdv_bsi.Size = new System.Drawing.Size(85, 49);
            this.bt_viewhsdv_bsi.TabIndex = 9;
            this.bt_viewhsdv_bsi.Text = "View hsdv bacsi";
            this.bt_viewhsdv_bsi.UseVisualStyleBackColor = true;
            this.bt_viewhsdv_bsi.Click += new System.EventHandler(this.bt_viewhsdv_bsi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_update1);
            this.groupBox2.Controls.Add(this.tb_kb);
            this.groupBox2.Controls.Add(this.tb_ketluan1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_nguoith);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 200);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infor_hosobenhan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khám bệnh";
            // 
            // tb_kb
            // 
            this.tb_kb.Location = new System.Drawing.Point(133, 35);
            this.tb_kb.Name = "tb_kb";
            this.tb_kb.Size = new System.Drawing.Size(100, 22);
            this.tb_kb.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Người thực hiện";
            // 
            // tb_nguoith
            // 
            this.tb_nguoith.Location = new System.Drawing.Point(133, 73);
            this.tb_nguoith.Name = "tb_nguoith";
            this.tb_nguoith.Size = new System.Drawing.Size(100, 22);
            this.tb_nguoith.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kết luận";
            // 
            // tb_ketluan1
            // 
            this.tb_ketluan1.Location = new System.Drawing.Point(133, 110);
            this.tb_ketluan1.Name = "tb_ketluan1";
            this.tb_ketluan1.Size = new System.Drawing.Size(100, 22);
            this.tb_ketluan1.TabIndex = 1;
            // 
            // bt_update1
            // 
            this.bt_update1.Location = new System.Drawing.Point(133, 148);
            this.bt_update1.Name = "bt_update1";
            this.bt_update1.Size = new System.Drawing.Size(92, 40);
            this.bt_update1.TabIndex = 2;
            this.bt_update1.Text = "Update";
            this.bt_update1.UseVisualStyleBackColor = true;
            this.bt_update1.Click += new System.EventHandler(this.bt_update1_Click);
            // 
            // Form_BACSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_viewhsdv_bsi);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_hsdichvu);
            this.Controls.Add(this.dgv_hsbenhnhan);
            this.Controls.Add(this.bt_viewhsbenhan);
            this.Name = "Form_BACSI";
            this.Text = "Form_BACSI";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsbenhnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hsdichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt_viewhsbenhan;
        private System.Windows.Forms.DataGridView dgv_hsbenhnhan;
        private System.Windows.Forms.DataGridView dgv_hsdichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_ketluan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.Button bt_viewhsdv_bsi;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.TextBox tb_makhambenh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nguoithuchien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_update1;
        private System.Windows.Forms.TextBox tb_kb;
        private System.Windows.Forms.TextBox tb_ketluan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nguoith;
    }
}

namespace giaodien_phanhe2
{
    partial class Form_NVBANTHUOC
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
            this.tb_madt = new System.Windows.Forms.TextBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.dgv_toathuoc = new System.Windows.Forms.DataGridView();
            this.bt_viewtoathuoc = new System.Windows.Forms.Button();
            this.dgv_benhnhan = new System.Windows.Forms.DataGridView();
            this.dgv_hosobenhan = new System.Windows.Forms.DataGridView();
            this.dgv_hosodichvu = new System.Windows.Forms.DataGridView();
            this.bt_viewdonthuoc = new System.Windows.Forms.Button();
            this.bt_viewbenhnhan = new System.Windows.Forms.Button();
            this.bt_hosobn = new System.Windows.Forms.Button();
            this.bt_hosodichvu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_sua1 = new System.Windows.Forms.Button();
            this.tb_nvpt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_toathuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benhnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hosobenhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hosodichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MADT";
            // 
            // tb_madt
            // 
            this.tb_madt.Location = new System.Drawing.Point(62, 32);
            this.tb_madt.Name = "tb_madt";
            this.tb_madt.Size = new System.Drawing.Size(118, 22);
            this.tb_madt.TabIndex = 1;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(996, 12);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 31);
            this.bt_back.TabIndex = 2;
            this.bt_back.Text = "Back";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // dgv_toathuoc
            // 
            this.dgv_toathuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_toathuoc.Location = new System.Drawing.Point(12, 12);
            this.dgv_toathuoc.Name = "dgv_toathuoc";
            this.dgv_toathuoc.RowHeadersWidth = 51;
            this.dgv_toathuoc.RowTemplate.Height = 24;
            this.dgv_toathuoc.Size = new System.Drawing.Size(356, 206);
            this.dgv_toathuoc.TabIndex = 3;
            this.dgv_toathuoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_toathuoc_CellContentClick);
            // 
            // bt_viewtoathuoc
            // 
            this.bt_viewtoathuoc.Location = new System.Drawing.Point(31, 224);
            this.bt_viewtoathuoc.Name = "bt_viewtoathuoc";
            this.bt_viewtoathuoc.Size = new System.Drawing.Size(96, 48);
            this.bt_viewtoathuoc.TabIndex = 4;
            this.bt_viewtoathuoc.Text = "View Toa thuoc";
            this.bt_viewtoathuoc.UseVisualStyleBackColor = true;
            this.bt_viewtoathuoc.Click += new System.EventHandler(this.bt_viewtoathuoc_Click);
            // 
            // dgv_benhnhan
            // 
            this.dgv_benhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_benhnhan.Location = new System.Drawing.Point(403, 12);
            this.dgv_benhnhan.Name = "dgv_benhnhan";
            this.dgv_benhnhan.RowHeadersWidth = 51;
            this.dgv_benhnhan.RowTemplate.Height = 24;
            this.dgv_benhnhan.Size = new System.Drawing.Size(356, 206);
            this.dgv_benhnhan.TabIndex = 5;
            // 
            // dgv_hosobenhan
            // 
            this.dgv_hosobenhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hosobenhan.Location = new System.Drawing.Point(12, 278);
            this.dgv_hosobenhan.Name = "dgv_hosobenhan";
            this.dgv_hosobenhan.RowHeadersWidth = 51;
            this.dgv_hosobenhan.RowTemplate.Height = 24;
            this.dgv_hosobenhan.Size = new System.Drawing.Size(356, 206);
            this.dgv_hosobenhan.TabIndex = 5;
            // 
            // dgv_hosodichvu
            // 
            this.dgv_hosodichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hosodichvu.Location = new System.Drawing.Point(403, 278);
            this.dgv_hosodichvu.Name = "dgv_hosodichvu";
            this.dgv_hosodichvu.RowHeadersWidth = 51;
            this.dgv_hosodichvu.RowTemplate.Height = 24;
            this.dgv_hosodichvu.Size = new System.Drawing.Size(356, 206);
            this.dgv_hosodichvu.TabIndex = 5;
            // 
            // bt_viewdonthuoc
            // 
            this.bt_viewdonthuoc.Location = new System.Drawing.Point(216, 224);
            this.bt_viewdonthuoc.Name = "bt_viewdonthuoc";
            this.bt_viewdonthuoc.Size = new System.Drawing.Size(84, 48);
            this.bt_viewdonthuoc.TabIndex = 6;
            this.bt_viewdonthuoc.Text = "View don thuoc";
            this.bt_viewdonthuoc.UseVisualStyleBackColor = true;
            this.bt_viewdonthuoc.Click += new System.EventHandler(this.bt_viewdonthuoc_Click);
            // 
            // bt_viewbenhnhan
            // 
            this.bt_viewbenhnhan.Location = new System.Drawing.Point(562, 224);
            this.bt_viewbenhnhan.Name = "bt_viewbenhnhan";
            this.bt_viewbenhnhan.Size = new System.Drawing.Size(83, 48);
            this.bt_viewbenhnhan.TabIndex = 7;
            this.bt_viewbenhnhan.Text = "View benh nhan";
            this.bt_viewbenhnhan.UseVisualStyleBackColor = true;
            this.bt_viewbenhnhan.Click += new System.EventHandler(this.bt_viewbenhnhan_Click);
            // 
            // bt_hosobn
            // 
            this.bt_hosobn.Location = new System.Drawing.Point(111, 507);
            this.bt_hosobn.Name = "bt_hosobn";
            this.bt_hosobn.Size = new System.Drawing.Size(112, 50);
            this.bt_hosobn.TabIndex = 8;
            this.bt_hosobn.Text = "View hosobenhan";
            this.bt_hosobn.UseVisualStyleBackColor = true;
            this.bt_hosobn.Click += new System.EventHandler(this.bt_hosobn_Click);
            // 
            // bt_hosodichvu
            // 
            this.bt_hosodichvu.Location = new System.Drawing.Point(550, 507);
            this.bt_hosodichvu.Name = "bt_hosodichvu";
            this.bt_hosodichvu.Size = new System.Drawing.Size(95, 50);
            this.bt_hosodichvu.TabIndex = 9;
            this.bt_hosodichvu.Text = "View hosodichvu";
            this.bt_hosodichvu.UseVisualStyleBackColor = true;
            this.bt_hosodichvu.Click += new System.EventHandler(this.bt_hosodichvu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_sua1);
            this.groupBox1.Controls.Add(this.tb_salary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_nvpt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_madt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(777, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 226);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor";
            // 
            // bt_sua1
            // 
            this.bt_sua1.Location = new System.Drawing.Point(62, 167);
            this.bt_sua1.Name = "bt_sua1";
            this.bt_sua1.Size = new System.Drawing.Size(88, 39);
            this.bt_sua1.TabIndex = 11;
            this.bt_sua1.Text = "Update";
            this.bt_sua1.UseVisualStyleBackColor = true;
            this.bt_sua1.Click += new System.EventHandler(this.bt_sua1_Click);
            // 
            // tb_nvpt
            // 
            this.tb_nvpt.Location = new System.Drawing.Point(62, 74);
            this.tb_nvpt.Name = "tb_nvpt";
            this.tb_nvpt.Size = new System.Drawing.Size(118, 22);
            this.tb_nvpt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "NVPT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Salary";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(62, 115);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(118, 22);
            this.tb_salary.TabIndex = 1;
            // 
            // Form_NVBANTHUOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_hosodichvu);
            this.Controls.Add(this.bt_hosobn);
            this.Controls.Add(this.bt_viewbenhnhan);
            this.Controls.Add(this.bt_viewdonthuoc);
            this.Controls.Add(this.dgv_hosodichvu);
            this.Controls.Add(this.dgv_hosobenhan);
            this.Controls.Add(this.dgv_benhnhan);
            this.Controls.Add(this.bt_viewtoathuoc);
            this.Controls.Add(this.dgv_toathuoc);
            this.Controls.Add(this.bt_back);
            this.Name = "Form_NVBANTHUOC";
            this.Text = "Form_NVBANTHUOC";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_toathuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benhnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hosobenhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hosodichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_madt;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.DataGridView dgv_toathuoc;
        private System.Windows.Forms.Button bt_viewtoathuoc;
        private System.Windows.Forms.DataGridView dgv_benhnhan;
        private System.Windows.Forms.DataGridView dgv_hosobenhan;
        private System.Windows.Forms.DataGridView dgv_hosodichvu;
        private System.Windows.Forms.Button bt_viewdonthuoc;
        private System.Windows.Forms.Button bt_viewbenhnhan;
        private System.Windows.Forms.Button bt_hosobn;
        private System.Windows.Forms.Button bt_hosodichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_nvpt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_sua1;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label label3;
    }
}
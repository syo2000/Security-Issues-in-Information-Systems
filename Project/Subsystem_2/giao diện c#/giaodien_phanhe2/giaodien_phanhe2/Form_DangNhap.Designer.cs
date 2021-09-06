
namespace giaodien_phanhe2
{
    partial class Form_DangNhap
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
            this.tb_username_dn = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pass_dn = new System.Windows.Forms.TextBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name";
            // 
            // tb_username_dn
            // 
            this.tb_username_dn.Location = new System.Drawing.Point(336, 113);
            this.tb_username_dn.Multiline = true;
            this.tb_username_dn.Name = "tb_username_dn";
            this.tb_username_dn.Size = new System.Drawing.Size(188, 32);
            this.tb_username_dn.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(288, 231);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(87, 41);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pass word";
            // 
            // tb_pass_dn
            // 
            this.tb_pass_dn.Location = new System.Drawing.Point(336, 171);
            this.tb_pass_dn.Multiline = true;
            this.tb_pass_dn.Name = "tb_pass_dn";
            this.tb_pass_dn.Size = new System.Drawing.Size(188, 32);
            this.tb_pass_dn.TabIndex = 1;
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(443, 231);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(81, 41);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Exit";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Form_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pass_dn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username_dn);
            this.Controls.Add(this.label1);
            this.Name = "Form_DangNhap";
            this.Text = "Form_DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username_dn;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pass_dn;
        private System.Windows.Forms.Button bt_thoat;
    }
}
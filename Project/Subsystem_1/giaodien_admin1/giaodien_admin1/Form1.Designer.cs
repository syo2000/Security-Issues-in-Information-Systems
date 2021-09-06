
namespace giaodien_admin1
{
    partial class Form1
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
            this.bt_viewuser = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.dgv_role = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_viewrole = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_rolename = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_createuser = new System.Windows.Forms.Button();
            this.bt_createrole = new System.Windows.Forms.Button();
            this.bt_deleteuser = new System.Windows.Forms.Button();
            this.bt_deleterole = new System.Windows.Forms.Button();
            this.bt_updateuser = new System.Windows.Forms.Button();
            this.bt_tab = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_privilegesroleforuser = new System.Windows.Forms.Button();
            this.bt_viewprivileges = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_tablespace2 = new System.Windows.Forms.TextBox();
            this.tb_quota2 = new System.Windows.Forms.TextBox();
            this.tb_quota1 = new System.Windows.Forms.Label();
            this.tb_tablespace1 = new System.Windows.Forms.Label();
            this.bt_viewquota = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.tb_quota = new System.Windows.Forms.TextBox();
            this.tb_tablespace = new System.Windows.Forms.TextBox();
            this.bt_viewtablespace = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_viewroleontable = new System.Windows.Forms.Button();
            this.bt_viewpronsys = new System.Windows.Forms.Button();
            this.bt_viewroleofuser = new System.Windows.Forms.Button();
            this.bt_viewprivilegesontable = new System.Windows.Forms.Button();
            this.dgv_tablespace = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablespace)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_viewuser
            // 
            this.bt_viewuser.Location = new System.Drawing.Point(134, 644);
            this.bt_viewuser.Name = "bt_viewuser";
            this.bt_viewuser.Size = new System.Drawing.Size(134, 44);
            this.bt_viewuser.TabIndex = 0;
            this.bt_viewuser.Text = "View user";
            this.bt_viewuser.UseVisualStyleBackColor = true;
            this.bt_viewuser.Click += new System.EventHandler(this.bt_viewuser_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(11, 326);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.Size = new System.Drawing.Size(385, 312);
            this.dgv_user.TabIndex = 1;
            this.dgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user_CellClick);
            // 
            // dgv_role
            // 
            this.dgv_role.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role.Location = new System.Drawing.Point(416, 326);
            this.dgv_role.Name = "dgv_role";
            this.dgv_role.RowHeadersWidth = 51;
            this.dgv_role.RowTemplate.Height = 24;
            this.dgv_role.Size = new System.Drawing.Size(403, 312);
            this.dgv_role.TabIndex = 2;
            this.dgv_role.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_role_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Role/Privileges";
            // 
            // bt_viewrole
            // 
            this.bt_viewrole.Location = new System.Drawing.Point(562, 644);
            this.bt_viewrole.Name = "bt_viewrole";
            this.bt_viewrole.Size = new System.Drawing.Size(134, 44);
            this.bt_viewrole.TabIndex = 5;
            this.bt_viewrole.Text = "View role";
            this.bt_viewrole.UseVisualStyleBackColor = true;
            this.bt_viewrole.Click += new System.EventHandler(this.bt_viewrole_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(91, 64);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 22);
            this.tb_password.TabIndex = 6;
            // 
            // tb_rolename
            // 
            this.tb_rolename.Location = new System.Drawing.Point(113, 38);
            this.tb_rolename.Name = "tb_rolename";
            this.tb_rolename.Size = new System.Drawing.Size(100, 22);
            this.tb_rolename.TabIndex = 7;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(91, 36);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 22);
            this.tb_username.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "User name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role name";
            // 
            // bt_createuser
            // 
            this.bt_createuser.Location = new System.Drawing.Point(6, 167);
            this.bt_createuser.Name = "bt_createuser";
            this.bt_createuser.Size = new System.Drawing.Size(94, 33);
            this.bt_createuser.TabIndex = 12;
            this.bt_createuser.Text = "Create user";
            this.bt_createuser.UseVisualStyleBackColor = true;
            this.bt_createuser.Click += new System.EventHandler(this.bt_createuser_Click);
            // 
            // bt_createrole
            // 
            this.bt_createrole.Location = new System.Drawing.Point(25, 74);
            this.bt_createrole.Name = "bt_createrole";
            this.bt_createrole.Size = new System.Drawing.Size(100, 33);
            this.bt_createrole.TabIndex = 13;
            this.bt_createrole.Text = "Create role";
            this.bt_createrole.UseVisualStyleBackColor = true;
            this.bt_createrole.Click += new System.EventHandler(this.bt_createrole_Click);
            // 
            // bt_deleteuser
            // 
            this.bt_deleteuser.Location = new System.Drawing.Point(106, 167);
            this.bt_deleteuser.Name = "bt_deleteuser";
            this.bt_deleteuser.Size = new System.Drawing.Size(100, 33);
            this.bt_deleteuser.TabIndex = 14;
            this.bt_deleteuser.Text = "Delete user";
            this.bt_deleteuser.UseVisualStyleBackColor = true;
            this.bt_deleteuser.Click += new System.EventHandler(this.bt_deleteuser_Click);
            // 
            // bt_deleterole
            // 
            this.bt_deleterole.Location = new System.Drawing.Point(131, 74);
            this.bt_deleterole.Name = "bt_deleterole";
            this.bt_deleterole.Size = new System.Drawing.Size(100, 33);
            this.bt_deleterole.TabIndex = 15;
            this.bt_deleterole.Text = "Delete role";
            this.bt_deleterole.UseVisualStyleBackColor = true;
            this.bt_deleterole.Click += new System.EventHandler(this.bt_deleterole_Click);
            // 
            // bt_updateuser
            // 
            this.bt_updateuser.Location = new System.Drawing.Point(50, 206);
            this.bt_updateuser.Name = "bt_updateuser";
            this.bt_updateuser.Size = new System.Drawing.Size(106, 33);
            this.bt_updateuser.TabIndex = 16;
            this.bt_updateuser.Text = "Update user";
            this.bt_updateuser.UseVisualStyleBackColor = true;
            this.bt_updateuser.Click += new System.EventHandler(this.bt_updateuser_Click);
            // 
            // bt_tab
            // 
            this.bt_tab.Location = new System.Drawing.Point(1148, 13);
            this.bt_tab.Name = "bt_tab";
            this.bt_tab.Size = new System.Drawing.Size(121, 33);
            this.bt_tab.TabIndex = 17;
            this.bt_tab.Text = "Privileges";
            this.bt_tab.UseVisualStyleBackColor = true;
            this.bt_tab.Click += new System.EventHandler(this.bt_tab_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(1148, 61);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(121, 33);
            this.bt_thoat.TabIndex = 18;
            this.bt_thoat.Text = "Back";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_privilegesroleforuser
            // 
            this.bt_privilegesroleforuser.Location = new System.Drawing.Point(224, 214);
            this.bt_privilegesroleforuser.Name = "bt_privilegesroleforuser";
            this.bt_privilegesroleforuser.Size = new System.Drawing.Size(83, 68);
            this.bt_privilegesroleforuser.TabIndex = 22;
            this.bt_privilegesroleforuser.Text = "Privileges role for user";
            this.bt_privilegesroleforuser.UseVisualStyleBackColor = true;
            this.bt_privilegesroleforuser.Click += new System.EventHandler(this.bt_privilegesroleforuser_Click);
            // 
            // bt_viewprivileges
            // 
            this.bt_viewprivileges.Location = new System.Drawing.Point(36, 23);
            this.bt_viewprivileges.Name = "bt_viewprivileges";
            this.bt_viewprivileges.Size = new System.Drawing.Size(98, 63);
            this.bt_viewprivileges.TabIndex = 17;
            this.bt_viewprivileges.Text = "View user privileges on column of table";
            this.bt_viewprivileges.UseVisualStyleBackColor = true;
            this.bt_viewprivileges.Click += new System.EventHandler(this.bt_viewprivileges_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_updateuser);
            this.groupBox1.Controls.Add(this.tb_tablespace2);
            this.groupBox1.Controls.Add(this.bt_deleteuser);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_quota2);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_quota1);
            this.groupBox1.Controls.Add(this.bt_createuser);
            this.groupBox1.Controls.Add(this.tb_tablespace1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 250);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create user";
            // 
            // tb_tablespace2
            // 
            this.tb_tablespace2.Location = new System.Drawing.Point(91, 94);
            this.tb_tablespace2.Name = "tb_tablespace2";
            this.tb_tablespace2.Size = new System.Drawing.Size(100, 22);
            this.tb_tablespace2.TabIndex = 26;
            // 
            // tb_quota2
            // 
            this.tb_quota2.Location = new System.Drawing.Point(91, 126);
            this.tb_quota2.Name = "tb_quota2";
            this.tb_quota2.Size = new System.Drawing.Size(100, 22);
            this.tb_quota2.TabIndex = 6;
            // 
            // tb_quota1
            // 
            this.tb_quota1.AutoSize = true;
            this.tb_quota1.Location = new System.Drawing.Point(8, 126);
            this.tb_quota1.Name = "tb_quota1";
            this.tb_quota1.Size = new System.Drawing.Size(47, 17);
            this.tb_quota1.TabIndex = 10;
            this.tb_quota1.Text = "Quota";
            // 
            // tb_tablespace1
            // 
            this.tb_tablespace1.AutoSize = true;
            this.tb_tablespace1.Location = new System.Drawing.Point(8, 94);
            this.tb_tablespace1.Name = "tb_tablespace1";
            this.tb_tablespace1.Size = new System.Drawing.Size(82, 17);
            this.tb_tablespace1.TabIndex = 10;
            this.tb_tablespace1.Text = "Tablespace";
            // 
            // bt_viewquota
            // 
            this.bt_viewquota.Location = new System.Drawing.Point(1112, 644);
            this.bt_viewquota.Name = "bt_viewquota";
            this.bt_viewquota.Size = new System.Drawing.Size(94, 44);
            this.bt_viewquota.TabIndex = 25;
            this.bt_viewquota.Text = "View Quota";
            this.bt_viewquota.UseVisualStyleBackColor = true;
            this.bt_viewquota.Click += new System.EventHandler(this.bt_viewquota_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "Update quota";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(8, 94);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(104, 31);
            this.bt_update.TabIndex = 14;
            this.bt_update.Text = "Update tablespace";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // tb_quota
            // 
            this.tb_quota.Location = new System.Drawing.Point(122, 63);
            this.tb_quota.Name = "tb_quota";
            this.tb_quota.Size = new System.Drawing.Size(100, 22);
            this.tb_quota.TabIndex = 14;
            // 
            // tb_tablespace
            // 
            this.tb_tablespace.Location = new System.Drawing.Point(122, 33);
            this.tb_tablespace.Name = "tb_tablespace";
            this.tb_tablespace.Size = new System.Drawing.Size(100, 22);
            this.tb_tablespace.TabIndex = 14;
            // 
            // bt_viewtablespace
            // 
            this.bt_viewtablespace.Location = new System.Drawing.Point(898, 644);
            this.bt_viewtablespace.Name = "bt_viewtablespace";
            this.bt_viewtablespace.Size = new System.Drawing.Size(94, 44);
            this.bt_viewtablespace.TabIndex = 23;
            this.bt_viewtablespace.Text = "View Tablespace";
            this.bt_viewtablespace.UseVisualStyleBackColor = true;
            this.bt_viewtablespace.Click += new System.EventHandler(this.bt_viewtablespace_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(30, 66);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(47, 17);
            this.Username.TabIndex = 9;
            this.Username.Text = "Quota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Table space";
            // 
            // bt_viewroleontable
            // 
            this.bt_viewroleontable.Location = new System.Drawing.Point(139, 38);
            this.bt_viewroleontable.Name = "bt_viewroleontable";
            this.bt_viewroleontable.Size = new System.Drawing.Size(108, 63);
            this.bt_viewroleontable.TabIndex = 21;
            this.bt_viewroleontable.Text = "View role privileges on table ";
            this.bt_viewroleontable.UseVisualStyleBackColor = true;
            this.bt_viewroleontable.Click += new System.EventHandler(this.bt_viewroleontable_Click);
            // 
            // bt_viewpronsys
            // 
            this.bt_viewpronsys.Location = new System.Drawing.Point(13, 38);
            this.bt_viewpronsys.Name = "bt_viewpronsys";
            this.bt_viewpronsys.Size = new System.Drawing.Size(108, 63);
            this.bt_viewpronsys.TabIndex = 20;
            this.bt_viewpronsys.Text = "View role privileges on system";
            this.bt_viewpronsys.UseVisualStyleBackColor = true;
            this.bt_viewpronsys.Click += new System.EventHandler(this.bt_viewpronsys_Click);
            // 
            // bt_viewroleofuser
            // 
            this.bt_viewroleofuser.Location = new System.Drawing.Point(325, 214);
            this.bt_viewroleofuser.Name = "bt_viewroleofuser";
            this.bt_viewroleofuser.Size = new System.Drawing.Size(83, 68);
            this.bt_viewroleofuser.TabIndex = 19;
            this.bt_viewroleofuser.Text = "View role of user";
            this.bt_viewroleofuser.UseVisualStyleBackColor = true;
            this.bt_viewroleofuser.Click += new System.EventHandler(this.bt_viewroleofuser_Click);
            // 
            // bt_viewprivilegesontable
            // 
            this.bt_viewprivilegesontable.Location = new System.Drawing.Point(36, 98);
            this.bt_viewprivilegesontable.Name = "bt_viewprivilegesontable";
            this.bt_viewprivilegesontable.Size = new System.Drawing.Size(98, 63);
            this.bt_viewprivilegesontable.TabIndex = 18;
            this.bt_viewprivilegesontable.Text = "View user privileges on table ";
            this.bt_viewprivilegesontable.UseVisualStyleBackColor = true;
            this.bt_viewprivilegesontable.Click += new System.EventHandler(this.bt_viewprivilegesontable_Click);
            // 
            // dgv_tablespace
            // 
            this.dgv_tablespace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tablespace.Location = new System.Drawing.Point(838, 326);
            this.dgv_tablespace.Name = "dgv_tablespace";
            this.dgv_tablespace.RowHeadersWidth = 51;
            this.dgv_tablespace.RowTemplate.Height = 24;
            this.dgv_tablespace.Size = new System.Drawing.Size(415, 312);
            this.dgv_tablespace.TabIndex = 22;
            this.dgv_tablespace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tablespace_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(994, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tablespace";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_rolename);
            this.groupBox3.Controls.Add(this.bt_deleterole);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.bt_createrole);
            this.groupBox3.Location = new System.Drawing.Point(6, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 125);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create role";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_tablespace);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Username);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.tb_quota);
            this.groupBox4.Controls.Add(this.bt_update);
            this.groupBox4.Location = new System.Drawing.Point(742, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(250, 275);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tablespace/quota";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_viewroleofuser);
            this.groupBox5.Controls.Add(this.bt_privilegesroleforuser);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Location = new System.Drawing.Point(11, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(414, 288);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bt_viewprivileges);
            this.groupBox6.Controls.Add(this.bt_viewprivilegesontable);
            this.groupBox6.Location = new System.Drawing.Point(234, 30);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(161, 167);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Infor privileges user";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox3);
            this.groupBox7.Location = new System.Drawing.Point(443, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(281, 284);
            this.groupBox7.TabIndex = 29;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Role";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.bt_viewroleontable);
            this.groupBox8.Controls.Add(this.bt_viewpronsys);
            this.groupBox8.Location = new System.Drawing.Point(6, 166);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(260, 112);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Infor privileges role";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 738);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_viewquota);
            this.Controls.Add(this.bt_viewrole);
            this.Controls.Add(this.bt_viewuser);
            this.Controls.Add(this.dgv_tablespace);
            this.Controls.Add(this.bt_tab);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_role);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.bt_viewtablespace);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tablespace)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button bt_viewuser;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.DataGridView dgv_role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_viewrole;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_rolename;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_createuser;
        private System.Windows.Forms.Button bt_createrole;
        private System.Windows.Forms.Button bt_deleteuser;
        private System.Windows.Forms.Button bt_deleterole;
        private System.Windows.Forms.Button bt_updateuser;
        private System.Windows.Forms.Button bt_tab;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_viewprivileges;
        private System.Windows.Forms.Button bt_viewroleontable;
        private System.Windows.Forms.Button bt_viewpronsys;
        private System.Windows.Forms.Button bt_viewroleofuser;
        private System.Windows.Forms.Button bt_viewprivilegesontable;
        private System.Windows.Forms.Button bt_privilegesroleforuser;
        private System.Windows.Forms.TextBox tb_quota;
        private System.Windows.Forms.TextBox tb_tablespace;
        private System.Windows.Forms.Button bt_viewtablespace;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_tablespace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_viewquota;
        private System.Windows.Forms.TextBox tb_quota2;
        private System.Windows.Forms.Label tb_quota1;
        private System.Windows.Forms.Label tb_tablespace1;
        private System.Windows.Forms.TextBox tb_tablespace2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}


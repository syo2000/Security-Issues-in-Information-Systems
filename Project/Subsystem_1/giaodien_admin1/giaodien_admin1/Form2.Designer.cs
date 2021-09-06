
namespace giaodien_admin1
{
    partial class Form2
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
            this.dgv_user1 = new System.Windows.Forms.DataGridView();
            this.dgv_role1 = new System.Windows.Forms.DataGridView();
            this.dgv_table = new System.Windows.Forms.DataGridView();
            this.dgv_attribute = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.tb_username1 = new System.Windows.Forms.TextBox();
            this.tb_role1 = new System.Windows.Forms.TextBox();
            this.tb_tablename = new System.Windows.Forms.TextBox();
            this.bt_loaddata = new System.Windows.Forms.Button();
            this.tb_attribute = new System.Windows.Forms.TextBox();
            this.lb_username1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_viewname = new System.Windows.Forms.TextBox();
            this.bt_revokeprivileges = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_option = new System.Windows.Forms.TextBox();
            this.bt_checkpr = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_checkpri = new System.Windows.Forms.TextBox();
            this.Update = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_upsel = new System.Windows.Forms.Button();
            this.bt_upinsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attribute)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_user1
            // 
            this.dgv_user1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user1.Location = new System.Drawing.Point(12, 26);
            this.dgv_user1.Name = "dgv_user1";
            this.dgv_user1.RowHeadersWidth = 51;
            this.dgv_user1.RowTemplate.Height = 24;
            this.dgv_user1.Size = new System.Drawing.Size(307, 181);
            this.dgv_user1.TabIndex = 0;
            this.dgv_user1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_user1_CellContentClick);
            // 
            // dgv_role1
            // 
            this.dgv_role1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_role1.Location = new System.Drawing.Point(340, 26);
            this.dgv_role1.Name = "dgv_role1";
            this.dgv_role1.RowHeadersWidth = 51;
            this.dgv_role1.RowTemplate.Height = 24;
            this.dgv_role1.Size = new System.Drawing.Size(307, 181);
            this.dgv_role1.TabIndex = 1;
            this.dgv_role1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_role1_CellContentClick);
            // 
            // dgv_table
            // 
            this.dgv_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_table.Location = new System.Drawing.Point(12, 267);
            this.dgv_table.Name = "dgv_table";
            this.dgv_table.RowHeadersWidth = 51;
            this.dgv_table.RowTemplate.Height = 24;
            this.dgv_table.Size = new System.Drawing.Size(307, 183);
            this.dgv_table.TabIndex = 2;
            this.dgv_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_table_CellContentClick);
            // 
            // dgv_attribute
            // 
            this.dgv_attribute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attribute.Location = new System.Drawing.Point(340, 267);
            this.dgv_attribute.Name = "dgv_attribute";
            this.dgv_attribute.RowHeadersWidth = 51;
            this.dgv_attribute.RowTemplate.Height = 24;
            this.dgv_attribute.Size = new System.Drawing.Size(307, 183);
            this.dgv_attribute.TabIndex = 3;
            this.dgv_attribute.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_attribute_CellValueChanged);
            this.dgv_attribute.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_attribute_CurrentCellDirtyStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Table name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Attribute";
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(6, 30);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(131, 42);
            this.bt_select.TabIndex = 8;
            this.bt_select.Text = "Privileges select ";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(153, 30);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(131, 42);
            this.bt_insert.TabIndex = 9;
            this.bt_insert.Text = "Privileges insert";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(6, 92);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(131, 41);
            this.bt_delete.TabIndex = 10;
            this.bt_delete.Text = "Privileges delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(153, 92);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(131, 41);
            this.bt_update.TabIndex = 11;
            this.bt_update.Text = "Privileges update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(224, 217);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(100, 33);
            this.bt_exit.TabIndex = 12;
            this.bt_exit.Text = "exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // tb_username1
            // 
            this.tb_username1.Location = new System.Drawing.Point(127, 33);
            this.tb_username1.Name = "tb_username1";
            this.tb_username1.Size = new System.Drawing.Size(138, 22);
            this.tb_username1.TabIndex = 13;
            // 
            // tb_role1
            // 
            this.tb_role1.Location = new System.Drawing.Point(127, 74);
            this.tb_role1.Name = "tb_role1";
            this.tb_role1.Size = new System.Drawing.Size(138, 22);
            this.tb_role1.TabIndex = 14;
            // 
            // tb_tablename
            // 
            this.tb_tablename.Location = new System.Drawing.Point(127, 118);
            this.tb_tablename.Name = "tb_tablename";
            this.tb_tablename.Size = new System.Drawing.Size(138, 22);
            this.tb_tablename.TabIndex = 15;
            // 
            // bt_loaddata
            // 
            this.bt_loaddata.Location = new System.Drawing.Point(261, 478);
            this.bt_loaddata.Name = "bt_loaddata";
            this.bt_loaddata.Size = new System.Drawing.Size(131, 46);
            this.bt_loaddata.TabIndex = 16;
            this.bt_loaddata.Text = "Load data";
            this.bt_loaddata.UseVisualStyleBackColor = true;
            this.bt_loaddata.Click += new System.EventHandler(this.bt_loaddata_Click);
            // 
            // tb_attribute
            // 
            this.tb_attribute.Location = new System.Drawing.Point(127, 161);
            this.tb_attribute.Name = "tb_attribute";
            this.tb_attribute.Size = new System.Drawing.Size(138, 22);
            this.tb_attribute.TabIndex = 17;
            // 
            // lb_username1
            // 
            this.lb_username1.AutoSize = true;
            this.lb_username1.Location = new System.Drawing.Point(48, 36);
            this.lb_username1.Name = "lb_username1";
            this.lb_username1.Size = new System.Drawing.Size(73, 17);
            this.lb_username1.TabIndex = 18;
            this.lb_username1.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Role";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Table";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Attribute";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tb_viewname);
            this.groupBox1.Controls.Add(this.tb_username1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_role1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_tablename);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_attribute);
            this.groupBox1.Controls.Add(this.lb_username1);
            this.groupBox1.Location = new System.Drawing.Point(668, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 251);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(48, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Viewname";
            // 
            // tb_viewname
            // 
            this.tb_viewname.Location = new System.Drawing.Point(127, 211);
            this.tb_viewname.Name = "tb_viewname";
            this.tb_viewname.Size = new System.Drawing.Size(138, 22);
            this.tb_viewname.TabIndex = 22;
            // 
            // bt_revokeprivileges
            // 
            this.bt_revokeprivileges.Location = new System.Drawing.Point(77, 207);
            this.bt_revokeprivileges.Name = "bt_revokeprivileges";
            this.bt_revokeprivileges.Size = new System.Drawing.Size(147, 41);
            this.bt_revokeprivileges.TabIndex = 23;
            this.bt_revokeprivileges.Text = "Revoke privileges ";
            this.bt_revokeprivileges.UseVisualStyleBackColor = true;
            this.bt_revokeprivileges.Click += new System.EventHandler(this.bt_revokeprivileges_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_option);
            this.groupBox2.Controls.Add(this.bt_select);
            this.groupBox2.Controls.Add(this.bt_insert);
            this.groupBox2.Controls.Add(this.bt_revokeprivileges);
            this.groupBox2.Controls.Add(this.bt_delete);
            this.groupBox2.Controls.Add(this.bt_update);
            this.groupBox2.Location = new System.Drawing.Point(668, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 256);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Privileges";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Select(1), Insert(2), Update(3), Delete(4)";
            // 
            // tb_option
            // 
            this.tb_option.Location = new System.Drawing.Point(104, 169);
            this.tb_option.Name = "tb_option";
            this.tb_option.Size = new System.Drawing.Size(100, 22);
            this.tb_option.TabIndex = 25;
            // 
            // bt_checkpr
            // 
            this.bt_checkpr.Location = new System.Drawing.Point(103, 186);
            this.bt_checkpr.Name = "bt_checkpr";
            this.bt_checkpr.Size = new System.Drawing.Size(131, 42);
            this.bt_checkpr.TabIndex = 26;
            this.bt_checkpr.Text = "Check Privileges Granted";
            this.bt_checkpr.UseVisualStyleBackColor = true;
            this.bt_checkpr.Click += new System.EventHandler(this.bt_checkpr_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.tb_checkpri);
            this.groupBox3.Controls.Add(this.bt_checkpr);
            this.groupBox3.Location = new System.Drawing.Point(990, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 235);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check Privileges";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 17);
            this.label12.TabIndex = 28;
            this.label12.Text = "Type";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Location = new System.Drawing.Point(176, 30);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 90);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "CheckPri(3)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(6, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(148, 99);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "Check_Ins_Sel_Del(2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "CheckUpdate(1)";
            // 
            // tb_checkpri
            // 
            this.tb_checkpri.Location = new System.Drawing.Point(116, 139);
            this.tb_checkpri.Name = "tb_checkpri";
            this.tb_checkpri.Size = new System.Drawing.Size(100, 22);
            this.tb_checkpri.TabIndex = 26;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(15, 30);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(139, 42);
            this.Update.TabIndex = 26;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button3);
            this.groupBox6.Controls.Add(this.bt_upsel);
            this.groupBox6.Controls.Add(this.bt_upinsert);
            this.groupBox6.Controls.Add(this.Update);
            this.groupBox6.Controls.Add(this.bt_exit);
            this.groupBox6.Location = new System.Drawing.Point(990, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(330, 256);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Update Privileges";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 42);
            this.button3.TabIndex = 29;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_upsel
            // 
            this.bt_upsel.Location = new System.Drawing.Point(176, 91);
            this.bt_upsel.Name = "bt_upsel";
            this.bt_upsel.Size = new System.Drawing.Size(148, 43);
            this.bt_upsel.TabIndex = 28;
            this.bt_upsel.Text = "Select";
            this.bt_upsel.UseVisualStyleBackColor = true;
            this.bt_upsel.Click += new System.EventHandler(this.bt_upsel_Click);
            // 
            // bt_upinsert
            // 
            this.bt_upinsert.Location = new System.Drawing.Point(15, 92);
            this.bt_upinsert.Name = "bt_upinsert";
            this.bt_upinsert.Size = new System.Drawing.Size(139, 42);
            this.bt_upinsert.TabIndex = 27;
            this.bt_upinsert.Text = "Insert";
            this.bt_upinsert.UseVisualStyleBackColor = true;
            this.bt_upinsert.Click += new System.EventHandler(this.bt_upinsert_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 551);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_loaddata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_attribute);
            this.Controls.Add(this.dgv_table);
            this.Controls.Add(this.dgv_role1);
            this.Controls.Add(this.dgv_user1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_role1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attribute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user1;
        private System.Windows.Forms.DataGridView dgv_role1;
        private System.Windows.Forms.DataGridView dgv_table;
        private System.Windows.Forms.DataGridView dgv_attribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.TextBox tb_username1;
        private System.Windows.Forms.TextBox tb_role1;
        private System.Windows.Forms.TextBox tb_tablename;
        private System.Windows.Forms.Button bt_loaddata;
        private System.Windows.Forms.TextBox tb_attribute;
        private System.Windows.Forms.Label lb_username1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_revokeprivileges;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_option;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_viewname;
        private System.Windows.Forms.Button bt_checkpr;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_checkpri;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_upsel;
        private System.Windows.Forms.Button bt_upinsert;
    }
}
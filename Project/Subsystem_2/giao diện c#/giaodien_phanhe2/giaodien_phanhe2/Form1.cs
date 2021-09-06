using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.Odbc;

namespace giaodien_phanhe2
{
    public partial class Form1 : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            
        }
        public Form1(string user_name, string pass, string role_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.pass = pass;
            this.role_name = role_name;
        }

        private void bt_createuser_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                 ");User Id = PH4; password = 1;";
                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();

                string plsql = "SELECT *FROM all_users";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                int temp = dt.Rows.Count;
                conn.Close();
                conn.Open();

                cmd = new OracleCommand("sp_TaoUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("User id", OracleDbType.Varchar2).Value = tb_username.Text;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = tb_password.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();

                dt.Load(dr);
                string plsql1 = "SELECT *FROM all_users";
                OracleCommand cmd1 = new OracleCommand(plsql1, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);

                int temp1 = dt1.Rows.Count;
                if (temp1 > temp)
                {
                    MessageBox.Show("Tạo user thành công!");
                }
                else if (temp1 <= temp || tb_username.Text == "" || tb_password.Text == "")
                {
                    MessageBox.Show("Người dùng này đã tồn tại, vui lòng tạo username khác!!!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_createrole_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH4; password = 1;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();

                string plsql = "select *from sys.dba_roles";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                int temp = dt.Rows.Count;
                conn.Close();
                conn.Open();

                cmd = new OracleCommand("sp_Taorole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Rolename", OracleDbType.Varchar2).Value = tb_rolename.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();

                dt.Load(dr);
                string plsql1 = "select *from sys.dba_roles";
                OracleCommand cmd1 = new OracleCommand(plsql1, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);

                int temp1 = dt1.Rows.Count;
                if (temp1 > temp)
                {
                    MessageBox.Show("Tạo role thành công!");
                }
                else if (temp1 <= temp || tb_username.Text == "" || tb_password.Text == "")
                {
                    MessageBox.Show("Role name này đã tồn tại, vui lòng tạo role name khác!!!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_viewuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)" +
           ")" +
           ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls = "SELECT *FROM all_users";
            cmd = new OracleCommand(pls, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_user.DataSource = dt;
            conn.Close();
        }

        private void bt_viewrole_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)" +
           ")" +
           ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls = "select *from sys.dba_roles";
            cmd = new OracleCommand(pls, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();
        }

        private void bt_assignrole_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
             ");User Id = PH4; password = 1;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_GrantRoleToUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
            cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_rolename.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Cấp quyền thành công!");
            conn.Close();
        }

        private void bt_revokeroleforuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
           // string pls = "REVOKE '" + tb_rolename.Text + "' + 'from ' + '" + tb_username.Text + "'";
            string pls = "REVOKE " + tb_rolename.Text + " FROM " + tb_username.Text + "";
            cmd = new OracleCommand(pls, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Revoke success!");
            conn.Close();
        }

        private void bt_viewroleofuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH4; password = 1;";

            //string pls = "SELECT * FROM DBA_ROLE_PRIVS where grantee = " + tb_username.Text + "";        
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_Viewroleofuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();
        }

        private void dgv_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_username.Text = dgv_user.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void dgv_role_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_role.CurrentCell.Selected = true;
            tb_rolename.Text = dgv_role.Rows[e.RowIndex].Cells["role"].Value.ToString();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_Viewroleofuser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);           
            dgv_user.DataSource = dt;
            conn.Close();
        }

        private void bt_view_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_View", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_view.DataSource = dt;
            conn.Close();
        }

        private void bt_revokeviewofuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_RevokeViewToUser", conn);
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2).Value = tb_username.Text;
            cmd.Parameters.Add("view_name", OracleDbType.Varchar2).Value = tb_viewname.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Revoke successful");
            conn.Close();
        }

        private void bt_viewcolumn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)" +
           ")" +
           ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls2 = "SELECT table_name FROM user_tables";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_table.DataSource = dt;
            conn.Close();
        }

        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls2 = "select column_name from USER_TAB_COLUMNS where table_name = '" + dgv_table.Rows[e.RowIndex].Cells["table_name"].Value.ToString() + "'";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tabcheck.Items.Add(dt.Rows[i]["column_name"].ToString());

            }
        }

        private void bt_xemnhanvien_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)" +
           ")" +
           ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls2 = "select *from nhanvien";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_nhanvien_ed.DataSource = dt;
        }

        void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void bt_fga_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
           "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
           "(CONNECT_DATA =" +
           "(SERVER = DEDICATED)" +
           "(SERVICE_NAME = XE)" +
           ")" +
           ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls2 = "select * from dba_fga_audit_trail";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_fga.DataSource = dt;
            this.dgv_fga.DataError += this.DataGridView_DataError;
            conn.Close();
        }

        private void bt_drop_fga_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("Drop_FGA_AUDIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Drop successful");
        }

        private void bt_create_fga_Click(object sender, EventArgs e)
        {
            
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("FGA_AUDIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Create successful");
        }

        private void bt_create_std_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("STANDARD_AUDIT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Create successful");
        }

        private void bt_dc_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "SELECT *FROM PH4.GIAIMA_NHANVIEN";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_dc.DataSource = dt;        
        }

        private void bt_vnv_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "SELECT *FROM PH4.GIAIMA_NHANVIEN";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_nv.DataSource = dt;
        }

        private void dgv_nv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv.Text = dgv_nv.Rows[e.RowIndex].Cells["manv"].Value.ToString();
            tb_lcb.Text = dgv_nv.Rows[e.RowIndex].Cells["luongcoban"].Value.ToString();
            tb_pc.Text = dgv_nv.Rows[e.RowIndex].Cells["phucap"].Value.ToString();
        }

        private void bt_ud_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("ph4.Update_nhanvien", conn);
            cmd.Parameters.Add("manv", OracleDbType.Varchar2).Value = tb_manv.Text;
            cmd.Parameters.Add("lcb", OracleDbType.Varchar2).Value = tb_lcb.Text;
            cmd.Parameters.Add("pc", OracleDbType.Varchar2).Value = tb_pc.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Update successful");        
        }

        private void bt_create_policy_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("ph4.sp_Run_Policy", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Run successful");
        }

        private void bt_drop_policy_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("ph4.sp_Drop_Policy", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Run successful");
        }

        private void bt_standard_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = ph4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select username, obj_name, action_name, timestamp from dba_audit_trail";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_std.DataSource = dt;
        }

        private void bt_temp_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = ph4; password = 1;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from temp";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_nhanvien_ed.DataSource = dt;
        }

        private void bt_drop_std_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = sys; password = 2301311, role = SYSDBA;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "delete from sys.aud$";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
               
        }

        private void dgv_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dgv_view.CurrentCell.Selected = true;
            tb_viewname.Text = dgv_view.Rows[e.RowIndex].Cells["view_name"].Value.ToString();                 
        }

        private void bt_grantforuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH4; password = 1;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_GrantViewToUser", conn);
            cmd.Parameters.Add("user_name", OracleDbType.Varchar2).Value = tb_username.Text;
            cmd.Parameters.Add("view_name", OracleDbType.Varchar2).Value = tb_viewname.Text;
            cmd.Parameters.Add("type", OracleDbType.Int32).Value = checkedListBox1.SelectedIndex;
            if (tabcheck.SelectedIndex == -1)
            {
                if(checkedListBox1.SelectedIndex == 0)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                }
                else if(checkedListBox1.SelectedIndex == 1)
                {
                    conn.Close();
                    conn.Open();
                    string plsql = "grant insert on "+tb_viewname.Text+" to "+tb_username.Text+"";
                    cmd = new OracleCommand(plsql, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                }
                else if (checkedListBox1.SelectedIndex == 2)
                {
                    conn.Close();
                    conn.Open();
                    string plsql = "grant update on " + tb_viewname.Text + " to " + tb_username.Text + "";
                    cmd = new OracleCommand(plsql, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                }
            }
            else {
                if (checkedListBox1.SelectedIndex == 2)
                {
                    conn.Close();
                    conn = new OracleConnection();
                    conn.ConnectionString = ConnectionString;
                    conn.Open();
                    cmd = new OracleCommand("sp_GrantUpdaeOnColumn", conn);
                    cmd.Parameters.Add("user_name", OracleDbType.Varchar2).Value = tb_username.Text;
                    cmd.Parameters.Add("view_name", OracleDbType.Varchar2).Value = tb_viewname.Text;
                    cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = tabcheck.Text;
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                }
            }
            
            
            MessageBox.Show("Grant successful");
            conn.Close();
        }
    }
}

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

namespace giaodien_admin1
{
    public partial class Form1 : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_viewuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH1; password = 123;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string pls = "SELECT *FROM all_users";
            cmd = new OracleCommand(pls,conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_user.DataSource = dt;
            conn.Close();


            //OracleCommand cmd = new OracleCommand();
            //cmd.CommandText = "SELECT * FROM all_users";
            //cmd.CommandType = CommandType.Text;
            //OracleDataReader dr = cmd.ExecuteReader();
            //dt = new DataTable();
            //dt.Load(dr);
            //dgv_user.DataSource = dt;
            //conn.Close();
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
                 ");User Id = PH1; password = 123;";
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
                cmd.Parameters.Add("tablespace", OracleDbType.Varchar2).Value = tb_tablespace2.Text;
                cmd.Parameters.Add("quota", OracleDbType.Varchar2).Value = tb_quota2.Text;
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
            catch(Exception ex)
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
                ");User Id = PH1; password = 123;";

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
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
   
        }

        private void dgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(MessageBox.Show("Bạn có chắc chắn muốn xóa user này?", "Xóa user",MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    dgv_user.CurrentCell.Selected = true;
            //    string user_name = dgv_user.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();


            //    tb_username.Text = dgv_user.Rows[e.RowIndex].Cells["username"].Value.ToString();
            //}    
            dgv_user.CurrentCell.Selected = true;
            tb_username.Text = dgv_user.Rows[e.RowIndex].Cells["username"].Value.ToString();

        }

        private void bt_deleteuser_Click(object sender, EventArgs e)
        {            
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();

                string plsql = "SELECT * FROM all_users";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                int temp = dt.Rows.Count;
                conn.Close();
                conn.Open();

                cmd = new OracleCommand("sp_Xoauser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();

                dt.Load(dr);
                string plsql1 = "SELECT * FROM all_users";
                OracleCommand cmd1 = new OracleCommand(plsql1, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);

                int temp1 = dt1.Rows.Count;
                if (temp1 == temp)
                {
                    MessageBox.Show("User name này đã tồn tại, vui lòng tạo username khác!!!");
                }
                else if (temp1 < temp || tb_username.Text == "" || tb_password.Text == "")
                {
                    MessageBox.Show("Xóa thành công!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_role_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_role.CurrentCell.Selected = true;
            tb_rolename.Text = dgv_role.Rows[e.RowIndex].Cells["role"].Value.ToString();
        }

        private void bt_deleterole_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

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

                cmd = new OracleCommand("sp_Xoarole", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("rolename", OracleDbType.Varchar2).Value = tb_rolename.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();

                dt.Load(dr);
                string plsql1 = "select *from sys.dba_roles";
                OracleCommand cmd1 = new OracleCommand(plsql1, conn);
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);

                int temp1 = dt1.Rows.Count;
                if (temp1 == temp)
                {
                    MessageBox.Show("User name này đã tồn tại, vui lòng tạo username khác!!!");
                }
                else if (temp1 < temp || tb_rolename.Text == "")
                {
                    MessageBox.Show("Xóa thành công!");
                }
                dgv_role.Refresh();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_updateuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH1; password = 123;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_Suauser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = tb_password.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            conn.Close();
            MessageBox.Show("Sửa thành công");
        }

        private void bt_tab_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH1; password = 123;";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            Form2 f = new Form2();
            this.Hide();
            f.ShowDialog();

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_viewrole_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
            ");User Id = PH1; password = 123;";

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

        private void bt_viewprivileges_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
                ");User Id = PH1; password = 123;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_UserXemQuyenTrenCot", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();
        }

        private void bt_viewprivilegesontable_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
               ");User Id = PH1; password = 123;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_UserXemQuyenTrenBang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
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
              ");User Id = PH1; password = 123;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "SELECT* FROM DBA_ROLE_PRIVS WHERE GRANTEE = '"+tb_username.Text+"'";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();

            //cmd = new OracleCommand("sp_XemRoleCuaUser", conn);


            //cmd.CommandType = CommandType.StoredProcedure;
            //dr = cmd.ExecuteReader();
            //dt = new DataTable();
            //dt.Load(dr);
            //dgv_role.DataSource = dt;
            //conn.Close();
        }

        private void bt_privilegesroleforuser_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
             "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
             "(CONNECT_DATA =" +
             "(SERVER = DEDICATED)" +
             "(SERVICE_NAME = XE)" +
             ")" +
              ");User Id = PH1; password = 123;";
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

        private void bt_viewroleontable_Click(object sender, EventArgs e)
        {        
                string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
               ");User Id = PH1; password = 123;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_RoleXemQuyenTrenBang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();

        }

        private void bt_viewpronsys_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = XE)" +
            ")" +
             ");User Id = PH1; password = 123;";
            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("sp_RoleXemQuyenHeThong", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role.DataSource = dt;
            conn.Close();
        }

        private void bt_viewtablespace_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();

                string plsql = "select username, default_tablespace from dba_users";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_tablespace.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgv_tablespace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_tablespace.CurrentCell.Selected = true;
            tb_tablespace.Text = dgv_tablespace.Rows[e.RowIndex].Cells["default_tablespace"].Value.ToString();
            tb_username.Text = dgv_tablespace.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();
                cmd = new OracleCommand("sp_UpdateTablespaceUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
                cmd.Parameters.Add("default_tablespace", OracleDbType.Varchar2).Value = tb_tablespace.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);              
                conn.Close();
                MessageBox.Show("Chỉnh sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();
                cmd = new OracleCommand("sp_UpdateQuotaUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username.Text;
                cmd.Parameters.Add("max_bytes", OracleDbType.Int32).Value = Int32.Parse(tb_quota.Text);
                cmd.Parameters.Add("default_tablespace", OracleDbType.Varchar2).Value = tb_tablespace.Text;
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                MessageBox.Show("Chỉnh sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_viewquota_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Data Source = (DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                "(CONNECT_DATA =" +
                "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)" +
                ")" +
                ");User Id = PH1; password = 123;";

                conn = new OracleConnection();
                conn.ConnectionString = ConnectionString;
                conn.Open();

                string plsql = "select tablespace_name, username, bytes, max_bytes from dba_ts_quotas";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_tablespace.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
      
    }
}

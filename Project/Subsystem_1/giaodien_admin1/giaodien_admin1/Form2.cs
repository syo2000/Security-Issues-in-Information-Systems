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
using System.Diagnostics;

namespace giaodien_admin1
{
    public partial class Form2 : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        OracleDataAdapter da;
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }

        private void dgv_user1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_user1.CurrentCell.Selected = true;
            tb_username1.Text = dgv_user1.Rows[e.RowIndex].Cells["username"].Value.ToString();
        }

        private void dgv_role1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_role1.CurrentCell.Selected = true;
            tb_role1.Text = dgv_role1.Rows[e.RowIndex].Cells["role"].Value.ToString();
        }

        private void dgv_attribute_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_attribute.CurrentCell.Selected = true;
            tb_attribute.Text = dgv_attribute.Rows[e.RowIndex].Cells["column_name"].Value.ToString();
        }

        private void dgv_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_table.CurrentCell.Selected = true;
            tb_tablename.Text = dgv_table.Rows[e.RowIndex].Cells["table_name"].Value.ToString();

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
            string pls2 = "select column_name from USER_TAB_COLUMNS where table_name = '" + dgv_table.Rows[e.RowIndex].Cells["table_name"].Value.ToString() + "'";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "Selected";
            checkColumn.HeaderText = "Selected";
            checkColumn.Width = 50;
            checkColumn.ReadOnly = false;
            checkColumn.FillWeight = 10; //if the datagridview is resized (on form resize) the checkbox won't take up too much; value is relative to the other columns' fill values
            try{
                dgv_attribute.Columns.Remove("Selected");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }           
            dgv_attribute.DataSource = dt;         
            dgv_attribute.Columns.Add(checkColumn);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void bt_loaddata_Click(object sender, EventArgs e)
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
            //load data cua user
            string pls = "SELECT *FROM all_users";
            cmd = new OracleCommand(pls, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_user1.DataSource = dt;
            //load data cua role
            string pls1 = "select *from sys.dba_roles";
            cmd = new OracleCommand(pls1, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_role1.DataSource = dt;
            //load data cac table SELECT table_name FROM user_tables
            string pls2 = "SELECT table_name FROM user_tables";
            cmd = new OracleCommand(pls2, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_table.DataSource = dt;


            conn.Close();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
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
            cmd = new OracleCommand("sp_Insert", conn);
            cmd.CommandType = CommandType.StoredProcedure;
     
            if (tb_username1.Text != "")
            {
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
            }
            else
            {
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
            }

            cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;

            if (dlr == DialogResult.Yes)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
            }
            else if (dlr == DialogResult.No) {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
            }
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Cấp quyền thành công!");
            conn.Close();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
            DialogResult dlr1 = MessageBox.Show("Grant select", "Bạn có muốn cấp quyền select cho user này?", MessageBoxButtons.YesNo);
           
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
            if (dlr1 == DialogResult.Yes)
            {
                OracleConnection conn1;
                conn1 = new OracleConnection();
                conn1.ConnectionString = ConnectionString;
                conn1.Open();
                
                OracleCommand cmd1 = new OracleCommand("sp_prSelect", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;
                if(tb_username1.Text == "")
                {
                    cmd1.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                else
                {
                    cmd1.Parameters.Add("User id", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                
                
                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                conn1.Close();
            }
            else if (dlr1 == DialogResult.No)
            {
                conn.Close();
            }
            cmd = new OracleCommand("sp_Delete", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (tb_username1.Text != "")
            {
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
            }
            else
            {
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
            }

            cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;


            if (dlr == DialogResult.Yes)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
            }
            else if (dlr == DialogResult.No)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
            }
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Cấp quyền thành công!");
            conn.Close();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
            DialogResult dlr1 = MessageBox.Show("Grant select", "Bạn có muốn cấp quyền select cho user này?", MessageBoxButtons.YesNo);

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
            if (dlr1 == DialogResult.Yes)
            {
                OracleConnection conn1;
                conn1 = new OracleConnection();
                conn1.ConnectionString = ConnectionString;
                conn1.Open();

                OracleCommand cmd1 = new OracleCommand("sp_prSelect", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;
                if (tb_username1.Text == "")
                {
                    cmd1.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                else
                {
                    cmd1.Parameters.Add("User id", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
               

                OracleDataReader dr1 = cmd1.ExecuteReader();
                DataTable dt1 = new DataTable();
                dt1.Load(dr1);
                conn1.Close();
            }
            else if (dlr1 == DialogResult.No)
            {
                conn.Close();
            }
            OracleCommand cmd = new OracleCommand("SP_UPDATE", conn);
            //cmd = new OracleCommand("sp_Update", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (tb_username1.Text != "")
            {
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
            }
            else
            {
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
            }

            cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = tb_attribute.Text;
            cmd.Parameters.Add("table_name", OracleDbType.Varchar2).Value = tb_tablename.Text;

            if (dlr == DialogResult.Yes)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
            }
            else if (dlr == DialogResult.No)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
            }
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Cấp quyền thành công!");
            conn.Close();
        }

        private void bt_revokeprivileges_Click(object sender, EventArgs e)
        {
            //DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
            //DialogResult dl = MessageBox.Show("cac", "lon?", MessageBoxButtons.RetryCancel);
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
            cmd = new OracleCommand("sp_Revoke", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (tb_username1.Text != "")
            {
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
            }
            else
            {
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
            }
            cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;
            cmd.Parameters.Add("type", OracleDbType.Varchar2).Value = tb_option.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Thu hồi quyền thành công!");
            conn.Close();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);              

            string pl = "";
            foreach (DataGridViewRow row in dgv_attribute.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.Equals(true)) //3 is the column number of checkbox
                {
                    row.Selected = true;
                    pl = pl + row.Cells[0].Value + ',';
                }
                else
                    row.Selected = false;
            }
            pl = pl.TrimEnd(pl[pl.Length - 1]);
            
            //DataGridViewSelectedRowCollection dgv1 = dgv_attribute.SelectedRows;
            //Trace.WriteLine(dgv1);
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
            cmd = new OracleCommand("sp_GrantSelectOnTable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (tb_username1.Text != "")
            {
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
            }
            else
            {
                cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
            }
            cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;
            cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = pl;
            if (dlr == DialogResult.Yes && tb_role1.Text == "")
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
            }
            else if (dlr == DialogResult.No)
            {
                cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
            }
            dgv_attribute.CurrentCell.Selected = true;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Cấp quyền thành công!");
            conn.Close();
        }

        private void dgv_attribute_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_attribute.IsCurrentCellDirty)
            {
                dgv_attribute.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgv_attribute_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_attribute.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.Equals(true)) //3 is the column number of checkbox
                {
                    row.Selected = true;
                    
                }
                else
                    row.Selected = false;
            }

            DataGridViewCheckBoxCell cell = this.dgv_attribute.CurrentCell as DataGridViewCheckBoxCell;
            // string pl = "";
            if (cell != null && !cell.ReadOnly)
            {             
                //this.dgv_attribute.RefreshEdit();
                //this.dgv_attribute.NotifyCurrentCellDirty(true);
                if ((bool)cell.Value)
                {
                    tb_attribute.Text = dgv_attribute.Rows[e.RowIndex].Cells["column_name"].Value.ToString();
                    //pl = pl + tb_attribute.Text;
                    //'"+ ds+"' "
                }
                else
                {
                    tb_attribute.Text = "";
                }
            }
        }

        private void bt_checkpr_Click(object sender, EventArgs e)
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

                if (tb_checkpri.Text == "1")
                {
                    cmd = new OracleCommand("sp_UserKTraQuyenTrenCot", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else if (tb_checkpri.Text == "2")
                {
                    cmd = new OracleCommand("sp_UserKtraQuyenTrenBang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else if (tb_checkpri.Text == "3")
                {
                    cmd = new OracleCommand("sp_RoleKtraQuyenTrenBang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_table.DataSource = dt;
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
           
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
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
                cmd = new OracleCommand("sp_ChinhSuaUpdateTrenCot", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (tb_username1.Text != "")
                {
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else
                {
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = tb_attribute.Text;
                cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;

                if (dlr == DialogResult.Yes)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
                }
                else if (dlr == DialogResult.No)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
                }
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                MessageBox.Show("Chỉnh sửa thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
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
                cmd = new OracleCommand("sp_ChinhSuaDelete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (tb_username1.Text != "")
                {
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else
                {
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;

                if (dlr == DialogResult.Yes)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
                }
                else if (dlr == DialogResult.No)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
                }
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                MessageBox.Show("Chỉnh sửa thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void bt_upinsert_Click(object sender, EventArgs e)
        {
            
            try
            {
                DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
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
                cmd = new OracleCommand("sp_ChinhSuaInsert", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (tb_username1.Text != "")
                {
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else
                {
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
                cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = tb_attribute.Text;
                cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;

                if (dlr == DialogResult.Yes)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
                }
                else if (dlr == DialogResult.No)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
                }
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                MessageBox.Show("Chỉnh sửa thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void bt_upsel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("With grant option", "Bạn có muốn sử dụng with grant option?", MessageBoxButtons.YesNo);
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
                cmd = new OracleCommand("sp_ChinhSuaSelectTrenView", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                if (tb_username1.Text != "")
                {
                    cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username1.Text;
                }
                else
                {
                    cmd.Parameters.Add("role", OracleDbType.Varchar2).Value = tb_role1.Text;
                }
               
                cmd.Parameters.Add("tablename", OracleDbType.Varchar2).Value = tb_tablename.Text;
                cmd.Parameters.Add("column_name", OracleDbType.Varchar2).Value = tb_attribute.Text;

                if (dlr == DialogResult.Yes)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 1;
                }
                else if (dlr == DialogResult.No)
                {
                    cmd.Parameters.Add("grant_option", OracleDbType.Int32).Value = 0;
                }
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                MessageBox.Show("Chỉnh sửa thành công!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

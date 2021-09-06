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
    public partial class Form_NVBANTHUOC : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;

        DataTable dt;

        public Form_NVBANTHUOC()
        {
            InitializeComponent();
            
        }

        private void bt_viewtoathuoc_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from PH4.Xem_thong_tin_toa_thuoc";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_toathuoc.DataSource = dt;
        }

        private void bt_viewdonthuoc_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from PH4.Xem_chinh_sua_don_thuoc";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_toathuoc.DataSource = dt;
        }

        private void bt_viewbenhnhan_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
               "(CONNECT_DATA =" +
               "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)" +
               ")" +
               ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from PH4.Xem_chinh_sua_thong_tin_BN";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_benhnhan.DataSource = dt;
        }

        private void bt_hosobn_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from PH4.Xem_ho_so_benh_an";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hosobenhan.DataSource = dt;
        }

        private void bt_hosodichvu_Click(object sender, EventArgs e)
        {
            
                string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            string plsql = "select *from PH4.Xem_ho_so_dich_vu";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hosodichvu.DataSource = dt;
        }

        private void bt_sua1_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source = (DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
              "(CONNECT_DATA =" +
              "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)" +
              ")" +
              ");User Id = " + user_name + "; password = " + pass + ";";

            conn = new OracleConnection();
            conn.ConnectionString = ConnectionString;
            conn.Open();
            cmd = new OracleCommand("ph4.sp_Update_NVPT_SALARY", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("madonthuoc", OracleDbType.Varchar2).Value = tb_madt.Text;
            cmd.Parameters.Add("nhanvienpt", OracleDbType.Varchar2).Value = tb_nvpt.Text;
            cmd.Parameters.Add("s", OracleDbType.Varchar2).Value = tb_salary.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            //string plsql = "update ph4.Xem_chinh_sua_don_thuoc set NVPT = '"+tb_nvpt.Text+"', SALARY = '"+tb_salary.Text+"' where MADT = '"+tb_madt.Text+"'";
            ////cmd.CommandText = plsql;
            ////cmd.ExecuteNonQuery();
            //cmd = new OracleCommand(plsql, conn);
            //dr = cmd.ExecuteReader();
            //dt = new DataTable();
            //dt.Load(dr);
            //MessageBox.Show("Update success!");
            dgv_toathuoc.DataSource = dt;
        }

        private void dgv_toathuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_madt.Text = dgv_toathuoc.Rows[e.RowIndex].Cells["MADT"].Value.ToString();
            tb_nvpt.Text = dgv_toathuoc.Rows[e.RowIndex].Cells["NVPT"].Value.ToString();
            tb_salary.Text = dgv_toathuoc.Rows[e.RowIndex].Cells["SALARY"].Value.ToString();
        }

        public Form_NVBANTHUOC(string user_name, string pass, string role_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.pass = pass;
            this.role_name = role_name;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();
        }
    }
}

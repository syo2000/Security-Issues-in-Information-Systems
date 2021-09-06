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
    public partial class Form_TIEPTAN : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form_TIEPTAN()
        {
            InitializeComponent();
        }

        private void bt_viewhosodichvu_Click(object sender, EventArgs e)
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
            dgv_hsdv.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
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
            dgv_hsbn.DataSource = dt;
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();
        }

        private void dgv_hsbn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_mabn.Text = dgv_hsbn.Rows[e.RowIndex].Cells["mabn"].Value.ToString();
            tb_ht.Text = dgv_hsbn.Rows[e.RowIndex].Cells["tenbn"].Value.ToString();
            tb_ngaysinh.Text = dgv_hsbn.Rows[e.RowIndex].Cells["ngaysinh"].Value.ToString();
            tb_diachi.Text = dgv_hsbn.Rows[e.RowIndex].Cells["diachi"].Value.ToString();
            tb_sdt.Text = dgv_hsbn.Rows[e.RowIndex].Cells["sdt"].Value.ToString();
        }

        private void bt_insert_Click(object sender, EventArgs e)
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
            cmd = new OracleCommand("PH4.SP_INSERT_BENHNHAN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("mabn1", OracleDbType.Varchar2).Value = tb_mabn.Text;
            cmd.Parameters.Add("tenbn1", OracleDbType.Varchar2).Value = tb_ht.Text;
            //OracleDbType.Date.ToString("dd-MMM-yyyy")
            cmd.Parameters.Add("ngaysinh1", OracleDbType.Varchar2).Value = tb_ngaysinh.Text;
            cmd.Parameters.Add("diachi1", OracleDbType.Varchar2).Value = tb_diachi.Text;
            cmd.Parameters.Add("sdt1", OracleDbType.Varchar2).Value = tb_sdt.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Insert success!");
        }

        private void bt_update_Click(object sender, EventArgs e)
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
            cmd = new OracleCommand("PH4.SP_UPDATE_THONGTINBN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("mabn1", OracleDbType.Varchar2).Value = tb_mabn.Text;
            cmd.Parameters.Add("tenbn1", OracleDbType.Varchar2).Value = tb_ht.Text;
            cmd.Parameters.Add("sdt1", OracleDbType.Int32).Value = tb_sdt.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Update success!");
        }

        public Form_TIEPTAN(string user_name, string pass, string role_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.pass = pass;
            this.role_name = role_name;
        }

        private void bt_view_hsba_Click(object sender, EventArgs e)
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
            dgv_hsba.DataSource = dt;
        }
    }
}

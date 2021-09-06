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

    public partial class Form_NVKETOAN : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form_NVKETOAN(string user_name, string pass, string role_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.pass = pass;
            this.role_name = role_name;
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
            cmd = new OracleCommand("PH4.sp_Grant_select_chamcong_update_nhanvien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2).Value = role_name;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();

        }

        private void dgv_nhanvien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tb_manv_nvkt.Text = dgv_nhanvien.Rows[e.RowIndex].Cells["manv"].Value.ToString();
            tb_hoten_nvkt.Text = dgv_nhanvien.Rows[e.RowIndex].Cells["tennv"].Value.ToString();
            tb_luongcoban_nvkt.Text = dgv_nhanvien.Rows[e.RowIndex].Cells["luongcoban"].Value.ToString();
            tb_phucap_nvkt.Text = dgv_nhanvien.Rows[e.RowIndex].Cells["phucap"].Value.ToString();
        }

        private void bt_sua2_Click(object sender, EventArgs e)
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
            cmd.Parameters.Add("manv", OracleDbType.Varchar2).Value = tb_manv_nvkt.Text;
            cmd.Parameters.Add("lcb", OracleDbType.Varchar2).Value = tb_luongcoban_nvkt.Text;
            cmd.Parameters.Add("pc", OracleDbType.Varchar2).Value = tb_phucap_nvkt.Text;
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            MessageBox.Show("Update successful");
        }

        private void bt_vnv_Click(object sender, EventArgs e)
        {
            string sql = "select *from PH4.sp_Grant_select_nhanvien";
            cmd = new OracleCommand(sql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_nhanvien.DataSource = dt;
        }

        private void bt_Viewchamcong_Click_1(object sender, EventArgs e)
        {
            string sql = "select *from PH4.chamcong";
            cmd = new OracleCommand(sql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_chamcong.DataSource = dt;          
        }

       
        private void bt_viewnhanvien_Click(object sender, EventArgs e)
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
            string sql = "select *from PH4.TINHLUONG";
            cmd = new OracleCommand(sql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_chamcong.DataSource = dt;
        }
    }
}

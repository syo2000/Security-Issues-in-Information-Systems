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
    public partial class Form_BACSI : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form_BACSI()
        {
            InitializeComponent();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();
        }

        private void bt_viewhsdichvu_Click(object sender, EventArgs e)
        {
            string plsql = "select *from PH4.hoso_dichvu";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hsdichvu.DataSource = dt;
        }

        private void bt_viewhsdv_bsi_Click(object sender, EventArgs e)
        {
            string plsql = "select *from PH4.BACSI_HOSO_DICHVU";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hsdichvu.DataSource = dt;
        }

        private void dgv_hsdichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_makhambenh.Text = dgv_hsdichvu.Rows[e.RowIndex].Cells["makb"].Value.ToString();
            tb_nguoithuchien.Text = dgv_hsdichvu.Rows[e.RowIndex].Cells["nguoithuchien"].Value.ToString();
            tb_ketluan.Text = dgv_hsdichvu.Rows[e.RowIndex].Cells["ketluan"].Value.ToString();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            
            cmd = new OracleCommand("PH4.sp_Update_hosodichvu", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("makhambenh", OracleDbType.Varchar2).Value = tb_makhambenh.Text;
            cmd.Parameters.Add("kl", OracleDbType.Varchar2).Value = tb_ketluan.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            //string plsql = "update ph4.hoso_dichvu set ketluan = '"+tb_ketluan.Text+"' where MAKB = '"+tb_makhambenh.Text+"'"; Convert.ToDateTime(tb_ngaygio.Text)
            //cmd = new OracleCommand(plsql, conn);
            //dr = cmd.ExecuteReader();
            //dt = new DataTable();
            //dt.Load(dr);
            dgv_hsdichvu.DataSource = dt;
        }

        private void bt_update1_Click(object sender, EventArgs e)
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
            cmd = new OracleCommand("PH4.UPDATE_HOSOBENHAN", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("MA_KB", OracleDbType.Varchar2).Value = tb_kb.Text;
            cmd.Parameters.Add("KET_LUAN", OracleDbType.Varchar2).Value = tb_ketluan1.Text;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hsbenhnhan.DataSource = dt;
            MessageBox.Show("Update sucesss");
        }

        private void dgv_hsbenhnhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_kb.Text = dgv_hsbenhnhan.Rows[e.RowIndex].Cells["makb"].Value.ToString();
            tb_nguoith.Text = dgv_hsbenhnhan.Rows[e.RowIndex].Cells["mabn"].Value.ToString();
            tb_ketluan1.Text = dgv_hsbenhnhan.Rows[e.RowIndex].Cells["ketluancuabacsi"].Value.ToString();
        }

        public Form_BACSI(string user_name, string pass, string role_name)
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
        }

        private void bt_viewhsbenhan_Click(object sender, EventArgs e)
        {
            string plsql = "select *from ph4.HOSOBENHAN";
            cmd = new OracleCommand(plsql, conn);
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dgv_hsbenhnhan.DataSource = dt;
        }

    }
}

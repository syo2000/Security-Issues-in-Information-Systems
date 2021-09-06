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
    public partial class Form_DangNhap : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form_DangNhap()
        {
            InitializeComponent();
        }


        private void bt_login_Click(object sender, EventArgs e)
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
            cmd = new OracleCommand("SP_Check_Login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username_dn.Text;
            cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = tb_pass_dn.Text;
            cmd.Parameters.Add("@checktype", OracleDbType.Int32).Direction = ParameterDirection.Output;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            string type = Convert.ToString(cmd.Parameters["@checktype"].Value.ToString());

            if (type == "1")
            {
                //conn.Close();
                //conn.Open();
                //string ConnectionString1 = "Data Source = (DESCRIPTION =" +
                //"(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                //"(CONNECT_DATA =" +
                //"(SERVER = DEDICATED)" +
                //"(SERVICE_NAME = XE)" +
                //    ")" +
                //");User Id = " + tb_username_dn.Text + "; password = " + tb_pass_dn.Text + ";";

                //string ConnectionString1 = "Data Source = (DESCRIPTION =" +
                //"(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                //"(CONNECT_DATA =" +
                //"(SERVER = DEDICATED)" +
                //"(SERVICE_NAME = XE)" +
                //    ")" +
                //");User Id = PH4; password = 1;";
                //conn = new OracleConnection();
                //conn.ConnectionString = ConnectionString1;
                //conn.Open();
                cmd = new OracleCommand("SP_GetRoleOfUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("username", OracleDbType.Varchar2).Value = tb_username_dn.Text;
                cmd.Parameters.Add("@temp_rolename", OracleDbType.Varchar2, 10).Direction = ParameterDirection.Output;

                //cmd = new OracleCommand("CAC", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                string role_name = Convert.ToString(cmd.Parameters["@temp_rolename"].Value.ToString());

                if (role_name == "QLCM")
                {
                    conn.Close();
                    //string ConnectionString1 = "Data Source = (DESCRIPTION =" +
                    //"(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-M1ECCII)(PORT = 1521))" +
                    //"(CONNECT_DATA =" +
                    //"(SERVER = DEDICATED)" +
                    //"(SERVICE_NAME = XE)" +
                    //    ")" +
                    //");User Id = " + tb_username_dn.Text + "; password = " + tb_pass_dn.Text + ";";
                    //conn = new OracleConnection();
                    //conn.ConnectionString = ConnectionString;
                    //conn.Open();
                    Form_QLCM f = new Form_QLCM(tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                else if(role_name == "NVKETOAN")
                {
                    conn.Close();
                    Form_NVKETOAN f = new Form_NVKETOAN(tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                else if (role_name == "admin1")
                {
                    conn.Close();
                    Form1 f = new Form1(tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                else if (role_name == "NVBANTHUOC")
                {
                    conn.Close();
                    Form_NVBANTHUOC f = new Form_NVBANTHUOC (tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                else if (role_name == "BACSI")
                {
                    conn.Close();
                    Form_BACSI f = new Form_BACSI(tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                else if (role_name == "NVTIEPTAN")
                {
                    conn.Close();
                    Form_TIEPTAN f = new Form_TIEPTAN(tb_username_dn.Text, tb_pass_dn.Text, role_name);
                    this.Hide();
                    f.ShowDialog();
                }
                //Form1 f = new Form1();               
                //this.Hide();
                //f.ShowDialog();
            }
            else
            MessageBox.Show("Login fail! Please enter username or password.");
            conn.Close();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

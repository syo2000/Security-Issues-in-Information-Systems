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
    public partial class Form_QLCM : Form
    {
        string user_name = "", pass = "", role_name = "";
        OracleConnection conn;
        OracleCommand cmd;
        OracleDataReader dr;
        DataTable dt;
        public Form_QLCM()
        {
            InitializeComponent();
        }

        public Form_QLCM(string user_name, string pass,string role_name)
        {
            InitializeComponent();
            this.user_name = user_name;
            this.pass = pass;
            this.role_name = role_name;
        }

        private void bt_view_Click(object sender, EventArgs e)
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
            cmd = new OracleCommand("PH4.sp_Viewalltable", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("role_name", OracleDbType.Varchar2).Value = role_name;
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);

            if (tb_choice.Text == "1")
            {
                string plsql = "select *from PH4.nhanvien";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if(tb_choice.Text == "2")
            {
                string plsql = "select *from PH4.BENHNHAN";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "3")
            {
                string plsql = "select *from PH4.chamcong";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "4")
            {
                string plsql = "select *from PH4.chitietdonthuoc";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "5")
            {
                string plsql = "select *from PH4.cthoadon";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "6")
            {
                string plsql = "select *from PH4.dichvu";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "7")
            {
                string plsql = "select *from PH4.donthuoc";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "8")
            {
                string plsql = "select *from PH4.hoadon";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "9")
            {
                string plsql = "select *from PH4.hoso_dichvu";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "10")
            {
                string plsql = "select *from PH4.hosobenhnhan";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "11")
            {
                string plsql = "select *from PH4.khoa";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            else if (tb_choice.Text == "12")
            {
                string plsql = "select *from PH4.thuoc";
                cmd = new OracleCommand(plsql, conn);
                dr = cmd.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgv_choice.DataSource = dt;
            }
            
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog();
        }
    }
}

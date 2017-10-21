using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiNhanh
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-0MT2C0B\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(connection);
            conn.Open();
            HienThi();
        }
        private void HienThi()
        {
            //string SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] ";
            //SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            //SqlDataReader dr = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //dgv_hienThi.DataSource = dt;
        }

        private void cb_chiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as Control).Text)
            {
                case "Chi Nhánh 1":
                    string SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN1'";
                    SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
                case "Chi Nhánh 2":
                    SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN2'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
                case "Chi Nhánh 3":
                    SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN3'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
                case "Chi Nhánh 4":
                    SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN4'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
                case "Chi Nhánh 5":
                    SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN5'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
                case "Chi Nhánh 6":
                    SqlSelect = "SELECT [Ma_CN],[Ten_CN],[SoDienThoai_CN],[DiaChi_CN],[TinhThanh] FROM [dbo].[CHI_NHANH] Where Ma_CN = 'CN6'";
                    cmd = new SqlCommand(SqlSelect, conn);
                    dr = cmd.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    dgv_hienThi.DataSource = dt;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_maChiNhanh.Text = "";
            text_tenChiNhanh.Text = "";
            text_soDienThoai.Text = "";
            text_diaChi.Text = "";
            text_tinhThanh.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SqlInsert = "INSERT INTO CHI_NHANH VALUES('" + text_maChiNhanh.Text + "','" + text_tenChiNhanh.Text + "','" + text_soDienThoai.Text + "','" + text_diaChi.Text + "','" + text_tinhThanh.Text + "')";
            SqlCommand cmd = new SqlCommand(SqlInsert, conn);
            cmd.ExecuteNonQuery();
            HienThi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

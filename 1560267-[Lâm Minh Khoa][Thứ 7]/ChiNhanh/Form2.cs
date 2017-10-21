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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private SqlConnection conn;
        private void Form2_Load(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-0MT2C0B\SQLEXPRESS;Initial Catalog=QuanLiQuanAn;Integrated Security=True";
            conn = new SqlConnection(connection);
            conn.Open();
            HienThi();
        }

        private void HienThi()
        {
            string SqlSelect = "SELECT [Ma_NV],[Ma_CN],[Ten_NV],[CMND],[SoDienThoai],[NgayBatDauLam],[ThamNien],[BoPhan],[CaLam],[Luong],[DanhGiaNhanVien] FROM [dbo].[NHAN_VIEN] ";
            SqlCommand cmd = new SqlCommand(SqlSelect, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgv_hienThi1.DataSource = dt;
        }
    }
}

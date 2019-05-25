using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLGV
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=ROBBIE-NGUYEN\\THINHNGUYEN;database=HeThongQLGV;integrated security = SSPI");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from GiaoVien",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGridViewGV.DataSource = dt;
            con.Close();
        }

        private void dtGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdGV.Text = dtGridViewGV.CurrentRow.Cells[0].Value.ToString();
            txtTenGV.Text = dtGridViewGV.CurrentRow.Cells[1].Value.ToString();
            txtBirthday.Text = dtGridViewGV.CurrentRow.Cells[2].Value.ToString();
            txtGender.Text = dtGridViewGV.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = dtGridViewGV.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dtGridViewGV.CurrentRow.Cells[5].Value.ToString();
            
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            string cm = string.Format("insert into GiaoVien values('{0}',N'{1}','{2}','{3}',N'{4}','{5}' )",
                txtIdGV.Text, txtTenGV.Text, txtBirthday.Text, txtGender.Text, txtAddress.Text, txtEmail.Text);
            SqlCommand sc = new SqlCommand(cm, con);
            sc.CommandType = CommandType.Text;
            sc.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Thêm dữ liệu thành công");
        }
    }
}

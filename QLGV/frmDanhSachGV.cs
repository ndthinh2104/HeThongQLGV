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
            SqlDataAdapter da = new SqlDataAdapter("select * from ChiTietGV",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGridViewGV.DataSource = dt;
            con.Close();
        }

        private void dtGridViewGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_insert_chitietgv";
            cmd.Parameters.Add("@id_gv", SqlDbType.Int).Value = txtIdGV.Text.Trim();
            cmd.Parameters.Add("@Chuc_vu", SqlDbType.NVarChar).Value = txtTenGV.Text.Trim();
            cmd.Parameters.Add("@Don_vi", SqlDbType.NVarChar).Value = txtAddress.Text.Trim();
            cmd.Parameters.Add("@Cac_mon_dam_nhiem", SqlDbType.NVarChar).Value = txtBirthday.Text.Trim();
            cmd.Parameters.Add("@Huong_nghien_cuu", SqlDbType.NVarChar).Value = txtEmail.Text.Trim();
            cmd.Parameters.Add("@Trinh_do_ngoai_ngu", SqlDbType.NVarChar).Value = txtGender.Text.Trim();
            cmd.Parameters.Add("@Khen_thuong", SqlDbType.NVarChar).Value = txtKhen.Text.Trim();
            cmd.Parameters.Add("@Ky_luat", SqlDbType.NVarChar).Value = txtKyLuat.Text.Trim();
            cmd.Parameters.Add("@Qua_trinh_dao_tao", SqlDbType.NVarChar).Value = txtQuaTrinh.Text.Trim();
            cmd.Connection = con;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

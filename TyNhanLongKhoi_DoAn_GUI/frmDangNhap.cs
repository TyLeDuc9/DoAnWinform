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
using System.Data;

namespace TyNhanLongKhoi_DoAn_GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát", "Confirm", MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
    
            if (result == DialogResult.Yes)
            {
                Close();    
            }
           
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-2LBUF1R9\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True;Encrypt=False");
            try
            {
                connect.Open();
                string taiKhoan = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;
                string sql = "select * from Admin where TaiKhoan= '" + taiKhoan + "' " +
                    "and MatKhau='" + matKhau + "'";
                SqlCommand cmd = new SqlCommand(sql, connect);
                SqlDataReader reader = cmd.ExecuteReader();     
                if (reader.Read())
                {
                  
                    MessageBox.Show("Đăng Nhập Thành Công");
                    frmTrangChu frmTrangChu = new frmTrangChu();
                    frmTrangChu.ShowDialog();  
                    this.Close();
            
                }
                else
                {
                    DialogResult result = MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Chưa Đúng", "CanhBao"
                        ,MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
              
                    
            }
        }

        private void chkHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkHienMatKhau.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar= true;
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
         
        }
    }
}

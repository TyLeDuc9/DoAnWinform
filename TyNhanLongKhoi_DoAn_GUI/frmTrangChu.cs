using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TyNhanLongKhoi_DoAn_BUS;


namespace TyNhanLongKhoi_DoAn_GUI
{
    public partial class frmTrangChu : Form
    {
        public frmTrangChu()
        {
            InitializeComponent();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDocGia frmDocGia = new frmDocGia();
            frmDocGia.ShowDialog();
            this.Show();    
        }

   

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLySach frmQuanLySach = new frmQuanLySach();  
            frmQuanLySach.ShowDialog(); 
            this.Show();
        }

        private void mnuQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
            this.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {

        }

        private void mnuMuonTra_Click(object sender, EventArgs e)
        {

        }

        private void mnuMuonSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMuonSach frmMuonSach = new frmMuonSach();
            frmMuonSach.ShowDialog();
            this.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTraSach frmTraSach=new frmTraSach();
            frmTraSach.ShowDialog();
            this.Show();
        }

        private void mnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Bạn có muốn thoát", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            } 
                
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDangNhap = new frmDangNhap();
            frmDangNhap.ShowDialog();
            frmTrangChu frmTrangChu = new frmTrangChu();
            frmTrangChu.Hide();
       
            
           
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}

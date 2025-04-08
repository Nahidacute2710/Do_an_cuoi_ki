using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTreeNode = Test_winform.Caynhiphantimkiem.TreeNode;

namespace Test_winform
{
    public partial class FormChuongTrinh : Form
    {
        private Caynhiphantimkiem.TreeNode nguoiDung;
        bool isThoat = true;
        
        public FormChuongTrinh(MyTreeNode nguoi)
        {
            InitializeComponent();
            nguoiDung = nguoi;
            labelHoten.Text = "Họ tên: " + nguoiDung.Ten;
            LabelThongtin.Text = "Thông tin: " + nguoiDung.ThongTinCaNhan;
            labelDiaChi.Text = "Địa chỉ: " + nguoiDung.DiaChi;

        }

        private void txtbutton3_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close(); // Đóng FormChuongTrinh
            FormDangNhap f = new FormDangNhap(); // Mở lại form đăng nhập
            f.Show();

        }

        private void FormChuongTrinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            Application.Exit();
        }
        

        private void txtbotton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelDiaChi_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelThongtin_Click(object sender, EventArgs e)
        {
            
        }

        private void labelHoten_Click(object sender, EventArgs e)
        {
            
        }
    }
}

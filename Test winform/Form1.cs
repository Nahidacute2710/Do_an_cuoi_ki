using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Test_winform.Caynhiphantimkiem;
using MyTreeNode = Test_winform.Caynhiphantimkiem.TreeNode;

namespace Test_winform
{
    
    public partial class FormDangNhap : Form
    {
        private Caynhiphantimkiem.TreeNode nguoiDung;
        private CayNhiPhan cay = new CayNhiPhan();
        public FormDangNhap()
        {
            InitializeComponent();
            cay.ChenThongTin(123, "Đinh Hoàng Nhã", "nha123", "quê quán hà nội, sinh viên", "sống tại quận 10 TPHCM");
            cay.ChenThongTin(467, "Đức Thành", "thanh718", "sinh viên, sinh 2006, yêu Duy Lợi", "Thủ Đức");
            cay.ChenThongTin(890, "Duy Lợi", "duyloi123", "sinh viên, sinh 2006, yêu Đức Thành", "Nhà Thành");
            cay.ChenThongTin(106, "Nghĩa Lê", "lee11", "sinh 2006, yêu Nam", "TPHCM");
            cay.ChenThongTin(107, "Nam", "nam11", "sinh 2006, yêu Nghĩa", "Nhà Nghĩa");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txbtaikhoan.Text, out id))
            {
                MessageBox.Show("ID phải là số!", "Lỗi");
                return;
            }

            string matkhau = txbmatkhau.Text;
            var nguoi = cay.TimKiemThongTin(id, matkhau);

            if (nguoi != null)
            {
                FormChuongTrinh f = new FormChuongTrinh(nguoi); // Truyền thông tin người dùng
                f.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Sai ID hoặc mật khẩu", "Lỗi");
                txbtaikhoan.Focus();
            }
        }

            private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbotton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}

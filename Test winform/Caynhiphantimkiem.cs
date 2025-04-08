using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_winform
{
    public class Caynhiphantimkiem
    {
        public class TreeNode
        {
            public int ID;
            public string Ten;
            public string MatKhau;
            public string ThongTinCaNhan;
            public string DiaChi;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int id, string ten, string matKhau, string thongTinCaNhan, string diaChi)
            {
                ID = id;
                Ten = ten;
                MatKhau = matKhau;
                ThongTinCaNhan = thongTinCaNhan;
                DiaChi = diaChi;
                Left = null;
                Right = null;
            }
        }

        public class CayNhiPhan
        {
            public TreeNode root;

            public void ChenThongTin(int id, string ten, string matKhau, string thongTinCaNhan, string diaChi)
            {
                root = ThemThongTinRec(root, id, ten, matKhau, thongTinCaNhan, diaChi);
            }

            private TreeNode ThemThongTinRec(TreeNode node, int id, string ten, string matKhau, string thongTinCaNhan, string diaChi)
            {
                if (node == null)
                {
                    return new TreeNode(id, ten, matKhau, thongTinCaNhan, diaChi);
                }

                int sosanh = id.CompareTo(node.ID); // So sánh ID

                if (sosanh > 0)
                {
                    node.Right = ThemThongTinRec(node.Right, id, ten, matKhau, thongTinCaNhan, diaChi);
                }
                else if (sosanh < 0)
                {
                    node.Left = ThemThongTinRec(node.Left, id, ten, matKhau, thongTinCaNhan, diaChi);
                }
                else
                {
                    Console.WriteLine("Tài Khoản Đã Tồn Tại.");
                }

                return node;
            }

            public TreeNode TimKiemThongTin(int id, string matKhau)
            {
                return TimKiemThongTinRec(root, id, matKhau);
            }

            private TreeNode TimKiemThongTinRec(TreeNode node, int id, string matKhau)
            {
                if (node == null) return null;

                int sosanh = id.CompareTo(node.ID); // So sánh ID

                if (sosanh == 0)
                {
                    if (node.MatKhau == matKhau)
                    {
                        return node;
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (sosanh < 0)
                {
                    return TimKiemThongTinRec(node.Left, id, matKhau);
                }
                else
                {
                    return TimKiemThongTinRec(node.Right, id, matKhau);
                }
            }
        }

       /* public class Program
        {
            static void Main(string[] args)
            {
                CayNhiPhan tree = new CayNhiPhan();
                tree.ChenThongTin(123, "Đinh Hoàng Nhã", "nha123", "quê quán hà nội, sinh viên,", "sinh viên, sống tại quận 10 tphcm");
                tree.ChenThongTin(467, "Đức thành", "thanh718", "sinh viên, sinh nam 2006 que quán động gay, đang yêu duy lợi", "sống tại thủ đức");
                tree.ChenThongTin(890, "Duy lợi", "duyloi123", "sinh viên, sinh nam 2006 que quán động gay, đang yêu duy thành", "sống tại nhà thành");
                tree.ChenThongTin(106, "Nghĩa lê", "lee11", "sinh viên, sinh nam 2006 que quán động gay, đang yêu em nam", "sống tại tphcm");
                tree.ChenThongTin(107, "Nam", "nam11", "sinh viên, sinh nam 2006 que quán động gay, đang yêu em nghĩa", "nhà em nghĩa");

                Console.WriteLine("Mời bạn nhập id muốn truy xuất thông tin cá nhân:");
                int id;
                while (!int.TryParse(Console.ReadLine(), out id) || id < 0)
                {
                    Console.WriteLine("Mời bạn nhập lại id không bao gồm chữ và số âm.");
                }

                Console.WriteLine("Mời bạn nhập mật khẩu: ");
                string matkhau = Console.ReadLine();

                var timKiem = tree.TimKiemThongTin(id, matkhau);
                if (timKiem != null)
                {
                    Console.WriteLine("Xác thực thành công!");
                    Console.WriteLine($"Họ tên: {timKiem.Ten}");
                    Console.WriteLine($"Thông tin cá nhân: {timKiem.ThongTinCaNhan}");
                    Console.WriteLine($"Địa chỉ: {timKiem.DiaChi}");
                }
                else
                {
                    Console.WriteLine("Sai thông tin đăng nhập.");
                }

                Console.ReadLine();
            }
        }*/
    }
}

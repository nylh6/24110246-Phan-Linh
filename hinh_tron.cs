using System;

namespace TinhToanHinhTron
{
    public class HinhTron
    {
        public double BanKinh { get; set; }
        public HinhTron(double banKinh)
        {
            BanKinh = banKinh;
        }

        //tính chu vi: C = 2 * PI * r
        public double TinhChuVi()
        {
            return 2 * Math.PI * BanKinh;
        }

        //tính diện tích: S = PI * r^2
        public double TinhDienTich()
        {
            return Math.PI * Math.Pow(BanKinh, 2);
        }

        public static void Main()
        {
            Console.Write("Nhập bán kính hình tròn: ");
            if (!double.TryParse(Console.ReadLine(), out double banKinh) || banKinh <= 0)
            {
                Console.WriteLine("Bán kính phải là một số lớn hơn 0.");
                return;
            }

            HinhTron hinhTron = new HinhTron(banKinh);
            Console.WriteLine($"Chu vi: {hinhTron.TinhChuVi():F2}");
            Console.WriteLine($"Diện tích: {hinhTron.TinhDienTich():F2}");
        }
    }
}
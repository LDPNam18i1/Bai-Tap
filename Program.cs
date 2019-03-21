using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Nhap so sinh vien");
            n = int.Parse(Console.ReadLine());
            // tao mang doi tuong Sv
            SinhVien[] sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                sv[i] = new SinhVien();
                sv[i].nhapTT();
                



            }
            Console.WriteLine("Danh sach Sinh Vien");
            for (int j = 0; j < n; j++)
            {
                sv[j].In();
            }
            Console.ReadKey();


            SinhVien tmp;
            tmp = sv[0];
            {
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = i + 1; j < n; j++)

                        if (sv[i].diemtb() < sv[j].diemtb())
                        {
                            tmp = sv[i];
                            sv[i] = sv[j];
                            sv[j] = tmp;
                        }
                }
            }

            Console.WriteLine("sinh vien sap xep theo thu tu giam dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("SV co diem tb {0} ", sv[i].diemtb());
            }
            Console.ReadLine();


            Console.WriteLine("Nhap ten  sinh vien can tim");
            string p = Console.ReadLine();
            for (int i = 0; i < n; i++)
                if (sv[i].tenSV.Contains(p))
                    Console.WriteLine("Ten SV muon tim la: Ten: {0}, Ma SV: {1}, Diem TB: {2}  ", sv[i].tenSV,sv[i].maSV,sv[i].diemtb());
            

            Console.ReadLine();




        }
    }
}
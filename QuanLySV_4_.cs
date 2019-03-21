using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class QuanLySV_4_
    {
        public String maSV;
        public String tenSV;
        public float diemTB;

        //default constructors
        public QuanLySV_4_()
        {
            this.maSV = "01";
            this.tenSV = "Le Dinh Phuong Nam";
            this.diemTB = (float)8.0;

        }
        //tham so hoa constructors
        public QuanLySV_4_(String maSV, String tenSV, float diemTB)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemTB = diemTB;
        }





        public void nhapTT()

        {



            Console.Write("Nhap Ten SV: ");
            this.tenSV = Console.ReadLine();

            Console.Write("Nhap ma SV: ");
            this.maSV = Console.ReadLine();

            Console.Write("Nhap Diem SV:");
            this.diemTB = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("--------------");





        }

        public void In()
        {
            Console.WriteLine("Ma SV: {0} ", this.maSV);
            Console.WriteLine("Ten SV: {0} ", this.tenSV);
            Console.WriteLine("Diem TB SV: {0} ", this.diemTB);
            Console.WriteLine("\n--------------------------\n");

        }

        public float diemtb()
        {
            return this.diemTB;
        }





    }
}


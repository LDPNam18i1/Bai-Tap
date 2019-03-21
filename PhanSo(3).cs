using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapPhanSo
{
    class PhanSo_3_
    {
        private int tuSo;
        private int mauSo;
        private int a;
        private int b;
        private int c;
        private int d;


        public PhanSo_3_() //Khởi tạo mặc định
        {
            this.tuSo = 0;
            this.mauSo = 0;
            this.a = 0;
            this.b = 0;
            this.c = 0;
            this.d = 0;
        }
        // Khởi tạo giá trị tử và mẫu số
        public PhanSo_3_(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void nhapHaiPhanSo()
        {
            Console.WriteLine("Nhap tu so thu 1: ");
            this.a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap mau so thu 1 : ");
            this.b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap tu so thu 2 : ");
            this.c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap tu so thu 2: ");
            this.d = Convert.ToInt32(Console.ReadLine());

        }

        public float  congHaiPhanSo()
        {
         
           
            this.tuSo = (this.a * this.d) + (this.c * this.b);
            this.mauSo = (this.b * this.d);
        
            float s= this.tuSo / this.mauSo;


            return s;
        }

        public float truHaiPhanSo()
        {
           
            this.tuSo = (this.a * this.d) - (this.c * this.b);
            this.mauSo = (this.b * this.d);
            float s = this.tuSo / this.mauSo;
            return s;

        }

        public float nhanHaiPhanSo()
        {
            
            this.tuSo = this.a * this.c;
            this.mauSo = (this.b * this.d);
            float s = this.tuSo / this.mauSo;
            return s;
        }

        public float chiaHaiPhanSo()
        {
            
            this.tuSo = (this.a * this.d);
            this.mauSo = (this.b * this.c);
            float s = this.tuSo / this.mauSo;
            return s;
        }

        public float nghichDaoHaiPhanSo()
        {
            
            
            
               
                Console.WriteLine("nghich dao 2 phan so: ");
                float p1 = (this.b / this.a);
                float p2 = (this.d / this.c);
                float s= (this.a * this.c) / (this.c * this.d);
            Console.WriteLine("{0}/{1}={2} va {3}/{4}={5}", this.b, this.a, p1, this.d, this.c, p2);


            return s;

            
        }

        public void hienThi()
        {
            Console.WriteLine("Cong 2 Phan So:");
            Console.WriteLine("{0}/{1}={2}",this.tuSo,this.mauSo,congHaiPhanSo());
            Console.WriteLine("Tru 2 Phan So:");
            Console.WriteLine("{0}/{1}={2}", this.tuSo, this.mauSo, truHaiPhanSo());
            Console.WriteLine("Nhan 2 Phan So:");
            Console.WriteLine("{0}/{1}={2}", this.tuSo, this.mauSo, nhanHaiPhanSo());
            Console.WriteLine("Chia 2 Phan So:");
            Console.WriteLine("{0}/{1}={2}", this.tuSo, this.mauSo, chiaHaiPhanSo());
           
            
        }
    }
}

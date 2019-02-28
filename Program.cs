using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            // bai 1
            TinhTong tong = new TinhTong();
            tong.nhapn();
            tong.tinhTong();
            tong.inTong();
            tong.tinhTong2();
            tong.tinhTong3();
            tong.tongUoc();

            // bai 2
            DoanTau tau = new DoanTau();
            tau.nhapMaDoanTau();
            tau.tinhTien();

            tau.inMatau();
            Console.ReadLine();



        }
    }
}

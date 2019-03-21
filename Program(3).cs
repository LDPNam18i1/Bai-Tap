using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapPhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo_3_ tinhPhanSo = new PhanSo_3_();
            tinhPhanSo.nhapHaiPhanSo();
            tinhPhanSo.congHaiPhanSo();
            tinhPhanSo.truHaiPhanSo();
            tinhPhanSo.nhanHaiPhanSo();
            tinhPhanSo.chiaHaiPhanSo();
            tinhPhanSo.nghichDaoHaiPhanSo();
            tinhPhanSo.hienThi();
            Console.ReadLine();

        }
    }
}

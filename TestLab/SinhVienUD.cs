using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab
{
    internal class SinhVienUD : SinhVien
    {
        int kiHoc;
        public SinhVienUD()
        {

        }

        public SinhVienUD(string maSinhVien, string ten, int namSinh, double diem, int kiHoc) : base(maSinhVien, ten, namSinh, diem)
        {
            this.kiHoc = kiHoc;
        }
        public int KiHoc { get => kiHoc; set => kiHoc = value; }

        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"Kì học {kiHoc}");
        }

    }
}

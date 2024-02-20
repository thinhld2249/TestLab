using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab
{
    internal class SinhVien
    {
        private string maSinhVien;
        private string ten;
        private int namSinh;
        private double diem;

        public SinhVien() { 

        }

        public string MaSinhVien { get => maSinhVien; set => maSinhVien = value; }
        public string Ten { get => ten; set => ten = value; }
        public int NamSinh { get => namSinh; set => namSinh = value; }
        public double Diem { get => diem; set => diem = value; }

        public SinhVien(string maSinhVien, string ten, int namSinh, double diem)
        {
            this.maSinhVien = maSinhVien;
            this.ten = ten;
            this.namSinh = namSinh;
            this.diem = diem;
        }

        public virtual void inThongTin()
        {
            Console.WriteLine($"Sinh viên {maSinhVien} tên {ten} sinh năm {namSinh} có điểm {diem}");
        }
   

    }
}

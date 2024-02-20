using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab
{
    internal class SinhVienService
    {
        private List<SinhVien> SVLst = new List<SinhVien>();

        public void nhapDanhSach()
        {
            string checkMSV = "";
            string check;
            do
            {

                SinhVien sinhVien = new SinhVien();

                Console.WriteLine("Nhập vào mã sinh viên ");
                sinhVien.MaSinhVien = Console.ReadLine();
                Console.WriteLine("Nhập vào tên sinh viên ");
                sinhVien.Ten = Console.ReadLine();
                Console.WriteLine("Nhập vào năm sinh sinh viên ");
                sinhVien.NamSinh = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập vào điểm sinh viên ");
                sinhVien.Diem = Convert.ToDouble(Console.ReadLine());
                SVLst.Add(sinhVien);
                Console.WriteLine("Bạn có muốn nhập tiếp không(Y/N)?");
                check = Console.ReadLine();

            } while (check.ToUpper() == "Y");

        }

        public void xuatDanhSach()
        {
            if (SVLst.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                return;
            }
            foreach (var sv in SVLst)
            {
                sv.inThongTin();
            }
        }

        public void veVip()
        {
            foreach (var sv in SVLst)
            {
                if (sv.Diem >= 8)
                {
                    sv.inThongTin();
                }
            }
        }

        public void xoaSvKhongThamgia()
        {
            DateTime year = DateTime.Now;
            for (int i = SVLst.Count; i >=0 ; i--)
            {
                if (SVLst[i].Diem < 8 && (year.Year - SVLst[i].NamSinh) > 25)
                {
                    SVLst.Remove(SVLst[i]);
                   
                }
            }
        }

        public void KeThua()
        {
            List<SinhVienUD> svUDLst = new List<SinhVienUD>()
            {
                new SinhVienUD("4","4",2004,4,4),
                new SinhVienUD("5","5",2005,5,5)
            };
            foreach (var sv in svUDLst)
            {
                sv.inThongTin();
            }
        }
    }
}

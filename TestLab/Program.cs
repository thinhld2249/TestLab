namespace TestLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int chucNang;
            SinhVienService sVService = new SinhVienService();
            do
            { 
                
                Console.WriteLine("====MENU====");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách các sinh viên được tặng vé vip HappyBee");
                Console.WriteLine("4.Xóa những sinh viên không được tham gia HappyBee nếu không được tặng");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.WriteLine("Xin mời chọn chức năng: ");
                 chucNang = Convert.ToInt32(Console.ReadLine());
                switch (chucNang)
                {
                    case 1:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Nhập danh sách đối tượng --- ");
                            sVService.nhapDanhSach();
                            break;
                        }
                    case 2:
                        {
                           Console.WriteLine("--- Bạn đang dùng chức năng Xuất danh sách đối tượng ---");
                            Console.WriteLine("Danh sách các sinh viên đã nhập: ");
                            sVService.xuatDanhSach();
                            
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Xuất danh sách các sinh viên được tặng vé vip HappyBee ---");
                            Console.WriteLine("Những sinh viên được tắng vé VIP: ");
                            sVService.veVip();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Xóa những sinh viên không được tham gia HappyBee nếu không được tặng --- ");
                            
                            sVService.xoaSvKhongThamgia();
                            Console.WriteLine("Những sinh viên còn lại sau khi xóa: ");
                            sVService.xuatDanhSach();
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Kế thừa ---");
                            sVService.KeThua();
                            break;
                        }
                    case 0:
                        {
                            Console.WriteLine("THOÁT");
                            Console.WriteLine("Nhấn phím bất kì để thoát!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Chức năng không hợp lệ!");
                            break;
                        }
                }

            } while (chucNang != 0);
        }
    }
}

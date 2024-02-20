namespace TestLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SinhVienService sVService = new SinhVienService();
            do
            { 
                switch (sVService.Menu())
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
                            
                            Console.WriteLine("Nhấn phím bất kì để thoát!");
                            Environment.Exit(0);
                            break;
                            
                        }
                    default:
                        {
                            Console.WriteLine("Chức năng không hợp lệ!");
                            break;
                        }
                }

            } while (true);
        }
    }
}

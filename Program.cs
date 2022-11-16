using System.Text;
using System.Text.RegularExpressions;
using TrainingSkeleton_SonDXT.Class_Object;
using TrainingSkeleton_SonDXT.Collection;
using TrainingSkeleton_SonDXT.DataStorage;
using TrainingSkeleton_SonDXT.PrimitiveTypes;

namespace TrainingSkeleton_SonDXT
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            int num;
            do
            {
                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                Console.WriteLine("1.PrimitiveType\n" + "2.Collection\n" + "3.Class-Object\n" + "4.DataStorage\n");
                Console.WriteLine("0.Nhập vào 0 để thoát.\n");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        {
                            int num1;
                            do
                            {
                                Console.WriteLine("Lựa chọn bài để kiểm tra: ");
                                Console.WriteLine("1.String\n" + "2.Int\n" + "3.Decimal\n" + "4.DateTime\n" + "5.Boolean\n");
                                Console.WriteLine("0.Nhập vào 0 để thoát.\n");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                switch (num1)
                                {
                                    case 1:
                                        {
                                            int num2;
                                            stringEx teststringEx = new stringEx();
                                            do
                                            {
                                                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Input: 1 chuỗi.\nNếu chuỗi null -> Thông báo: Chuỗi bị null\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\nCòn lại: In chuỗi ký tự ra màn hình \n"
                                                                + "\nBài2: Như 1.\nCòn lại: In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối\n"
                                                                + "\nBài3: Như 1.\r\nCòn lại: In chuỗi ký tự sau khi bỏ hết ký tự trắng\n"
                                                                + "\nBài4: Như 1.\r\nCòn lại: In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space\n"
                                                                + "\nBài5: Như 1.\r\nCòn lại: Đếm và thông báo số ký tự Space theo mẫu: Có [count] ký tự space\n"
                                                                + "\nBài6: Như 1.\r\nCòn lại: Đếm và thông báo số ký tự không phải Space theo mẫu: Có [count] ký tự không phải space\n"
                                                                + "\nBài7: Input: 2 chuỗi đầu vào (input1, input2)\r\nNếu 2 chuỗi giống nhau (Phân biệt hoa thường) -> Hiển thị kết quả: Chuỗi [input1] giống chuỗi [input2]\r\nNgược lại, Hiển thị kết quả: Chuỗi \"input1\"khác chuỗi \"input2\" \n"
                                                                + "\nBài8: Như 7 nhưng không phân biệt hoa thường\n"
                                                                + "\nBài9: Như 1.\r\nThay thế các đoạn \"ABC\" có trong chuỗi đầu vào bằng \"DEF\", CÓ phân biệt hoa thường\r\n"
                                                                + "\nBài10: Như 1.\r\nHiển thị chuỗi: Kính chào ông input. Chúc ngon miệng.\r\n(Giả sử input = \"Vũ Văn Chiến\" -> \"Kính chào ông Vũ Văn Chiến. Chúc ngon miệng.\") \n"
                                                                + "\nBài11: Như 1.\r\nĐảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả\n"
                                                                + "\nBài12: Input: 1 chuỗi và 1 số (count)\r\nNếu chuỗi null -> Thông báo: Chuỗi bị null\r\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\r\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\r\nNếu số < 0 -> Thông báo: Số nhỏ hơn 0\r\nCòn lại: Bỏ các ký tự trắng ở đầu chuỗi, cắt lấycount ký tự ĐẦU và in kết quả ra màn hình\r\n"
                                                                + "\nBài13: Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra màn hình \n"
                                                                + "\nBài14: Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra màn hình \n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Input: 1 chuỗi.\nNếu chuỗi null -> Thông báo: Chuỗi bị null\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\nCòn lại: In chuỗi ký tự ra màn hình \n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string1(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Như 1.\nCòn lại: In chuỗi ký tự sau khi bỏ ký tự trắng ở đầu và cuối\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string2(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\nBài3: Như 1.\r\nCòn lại: In chuỗi ký tự sau khi bỏ hết ký tự trắng\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string3(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\nBài4: Như 1.\r\nCòn lại: In chuỗi ký tự sau khi chuyển thành chữ hoa các ký tự đứng sau dấu Space\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string4(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("\nBài5: Như 1.\r\nCòn lại: Đếm và thông báo số ký tự Space theo mẫu: Có [count] ký tự space\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string5(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 6:
                                                        {
                                                            Console.WriteLine("\nBài6: Như 1.\r\nCòn lại: Đếm và thông báo số ký tự không phải Space theo mẫu: Có [count] ký tự không \r\nphải space\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string6(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 7:
                                                        {
                                                            Console.WriteLine("\nBài7: Input: 2 chuỗi đầu vào (input1, input2)\r\nNếu 2 chuỗi giống nhau (Phân biệt hoa thường) -> Hiển thị kết quả: Chuỗi [input1] giống \r\nchuỗi [input2]\r\nNgược lại, Hiển thị kết quả: Chuỗi \"input1\"khác chuỗi \"input2\" \n");
                                                            Console.WriteLine("Nhập vào chuỗi 1: ");
                                                            var str1 = Console.ReadLine();
                                                            Console.WriteLine("Nhập vào chuỗi 2: ");
                                                            var str2 = Console.ReadLine();
                                                            teststringEx.string7(str1, str2);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 8:
                                                        {
                                                            Console.WriteLine("\nBài8: Như 7 nhưng không phân biệt hoa thường\n");
                                                            Console.WriteLine("Nhập vào chuỗi 1: ");
                                                            var str1 = Console.ReadLine();
                                                            Console.WriteLine("Nhập vào chuỗi 2: ");
                                                            var str2 = Console.ReadLine();
                                                            teststringEx.string8(str1, str2);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 9:
                                                        {
                                                            Console.WriteLine("\nBài9: Như 1.\r\nThay thế các đoạn \"ABC\" có trong chuỗi đầu vào bằng \"DEF\", CÓ phân biệt hoa thường\r\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string9(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 10:
                                                        {
                                                            Console.WriteLine("\nBài10: Như 1.\r\nHiển thị chuỗi: Kính chào ông input. Chúc ngon miệng.\r\n(Giả sử input = \"Vũ Văn Chiến\" -> \"Kính chào ông Vũ Văn Chiến. Chúc ngon miệng.\") \n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string10(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 11:
                                                        {
                                                            Console.WriteLine("\nBài11: Như 1.\r\nĐảo ngược các ký tự của chuỗi và in ra màn hình chuỗi đầu vào và chuỗi kết quả\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            teststringEx.string11(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 12:
                                                        {
                                                            Console.WriteLine("\nBài12: Input: 1 chuỗi và 1 số (count)\r\nNếu chuỗi null -> Thông báo: Chuỗi bị null\r\nNếu chuỗi không có ký tự nào -> Thông báo: Chuỗi rỗng\r\nNếu chuỗi toàn ký tự space -> Thông báo: Chuỗi Space\r\nNếu số < 0 -> Thông báo: Số nhỏ hơn 0\r\nCòn lại: Bỏ các ký tự trắng ở đầu chuỗi, cắt lấycount ký tự ĐẦU và in kết quả ra màn hình\r\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            Console.WriteLine("Nhập vào số: ");
                                                            var count = Convert.ToInt32(Console.ReadLine());
                                                            teststringEx.string12(str, count);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 13:
                                                        {
                                                            Console.WriteLine("\nBài13: Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự ĐẦU và in kết quả ra màn hình \n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            Console.WriteLine("Nhập vào số: ");
                                                            var count = Convert.ToInt32(Console.ReadLine());
                                                            teststringEx.string13(str, count);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 14:
                                                        {
                                                            Console.WriteLine("\nBài14: Như 12\r\nCòn lại: Bỏ các ký tự trắng ở đầu và cuối chuỗi, cắt lấy count ký tự CUỐI và in kết quả ra màn hình \n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            Console.WriteLine("Nhập vào số: ");
                                                            var count = Convert.ToInt32(Console.ReadLine());
                                                            teststringEx.string14(str, count);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }

                                    case 2:
                                        {
                                            int num2;
                                            intEx testintEx = new intEx();
                                            do
                                            {
                                                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Nếu là số chẵn -> Thông báo: Số chẵn\r\nNếu là số lẻ -> Thông báo: Số lẻ\n"
                                                                + "\nBài2: Input: 1 số (x)\r\nHiển thị trị tuyệt đối của x\n"
                                                                + "\nBài3: Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Hiển thị 2 mũ x\n"
                                                                + "\nBài4: Input: 2 số (X, Y) \r\nHiển thị kết quả: X chia Y bằng ... dư...\n"
                                                                + "\nBài5: Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Nếu là số nguyên tố -> Thông báo: Số nguyên tố, ngược lại thông báo “Không phải số nguyên tố”\r\n"
                                                                + "\nBài6: Input: 1 chuỗi.\r\nNếu chuỗi là chuỗi số Int32 -> Thông báo: Chuỗi số.\r\nNgược lai -> Thông báo: Không phải chuỗi số\r\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Input: 1 số\r\nNếu số <= 0->Thông báo: Số <= 0\r\nCòn lại: Nếu là số chẵn->Thông báo: Số chẵn\r\nNếu là số lẻ->Thông báo: Số lẻ\n");
                                                            testintEx.int1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Input: 1 số (x)\r\nHiển thị trị tuyệt đối của x\n");
                                                            testintEx.int2();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\nBài3: Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Hiển thị 2 mũ x\n");
                                                            testintEx.int3();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\nBài4: Input: 2 số (X, Y) \r\nHiển thị kết quả: X chia Y bằng ... dư...\n");
                                                            testintEx.int4();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("\nBài5: Input: 1 số\r\nNếu số <= 0 -> Thông báo: Số <= 0\r\nCòn lại: Nếu là số nguyên tố -> Thông báo: Số nguyên tố, ngược lại thông báo “Không phải số nguyên tố”\r\n");
                                                            testintEx.int5();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 6:
                                                        {
                                                            Console.WriteLine("\nBài6: Input: 1 chuỗi.\r\nNếu chuỗi là chuỗi số Int32 -> Thông báo: Chuỗi số.\r\nNgược lai -> Thông báo: Không phải chuỗi số\r\n");
                                                            Console.WriteLine("Nhập vào chuỗi: ");
                                                            var str = Console.ReadLine();
                                                            testintEx.int6(str);
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }

                                    case 3:
                                        {
                                            int num2;
                                            decimalEx testdecimalEx = new decimalEx();
                                            do
                                            {
                                                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Input: 1 chuỗi.\r\nNếu chuỗi là chuỗi số thực (gồm các số, dấu ngăn cách phần nghìn là “,”, dấu phân cách thập phân là “.”): Chuỗi hợp lệ.\r\nNgược lai -> Thông báo: Không phải chuỗi decimal\r\nVí dụ chuỗi hợp lệ: 100; 1,000,000; 1,000.5\n"
                                                                + "\nBài2: Input: số decimal.\r\nChuyển số input thành string và in ra màn hình theo định dạng dấu ngăn cách phần nghìn là “,”, dấu phân cách thập phân là “.”, làm tròn 02 số sau dấu thập phân\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Input: 1 chuỗi.\r\nNếu chuỗi là chuỗi số thực(gồm các số, dấu ngăn cách phần nghìn là “,”, dấu phân cách thập phân là “.”): Chuỗi hợp lệ.\r\nNgược lai->Thông báo: Không phải chuỗi decimal\r\nVí dụ chuỗi hợp lệ: 100; 1,000,000; 1,000.5\n");
                                                            testdecimalEx.decimal1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Input: số decimal.\r\nChuyển số input thành string và in ra màn hình theo định dạng dấu ngăn cách phần nghìn là “,”, dấu phân cách thập phân là “.”, làm tròn 02 số sau dấu thập phân\n");
                                                            testdecimalEx.decimal2();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }

                                    case 4:
                                        {
                                            int num2;
                                            dateTimeEx testdateTimeEx = new dateTimeEx();
                                            do
                                            {
                                                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Lấy ngày hôm nay\r\nThông báo: Hôm nay là thứ ..., tháng..., năm...\r\n"
                                                                + "\nBài2: Input: 1 ngày.\r\nThông báo: Hôm nay là thứ ..., tháng..., năm...\r\n"
                                                                + "\nBài3: Input: 1 ngày.\r\nThông báo: Hôm sau là thứ ..., tháng..., năm...\n"
                                                                + "\nBài4: Input: 1 ngày.\r\nThông báo: Hôm trước là thứ ..., tháng..., năm..\n"
                                                                + "\nBài5: Input: 1 ngày.\r\nNếu là hôm nay -> Thông báo: Ngày hôm nay\r\nNếu là sau hôm nay -> Thông báo: Ngày tương lai\r\nNếu là trước hôm nay -> Thông báo: Ngày quá khứ\n"
                                                                + "\nBài6: Nhập 1 ngày.\r\nHiển thị ngày dưới dạng: Ngày/tháng/năm. VD:18/03/2014\r\nHiển thị ngày dưới dạng: Năm/tháng/ngày. VD: 2014/03/18\r\nHiển thị ngày dưới dạng: Tháng/năm. VD: 03/2014\r\nHiển thị ngày dưới dạng: Tháng-năm. VD: 03-2014\n"
                                                                + "\nBài7: Input: 1 ngày.\r\nHiển thị 10 ngày trước là thứ mấy\n"
                                                                + "\nBài8: Input: 1 ngày.\r\nHiển thị cuối tháng này là thứ mấy\r\n"
                                                                + "\nBài9: Input: 1 ngày.\r\nHiển thị cuối năm nay là thứ mấy\n"
                                                                + "\nBài10: Input: 2 ngày.\r\nHiển thị 2 ngày này cách nhau bao nhiêu ngày\r\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Lấy ngày hôm nay\r\nThông báo: Hôm nay là thứ ..., tháng..., năm...\r\n");
                                                            testdateTimeEx.dateTime1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Input: 1 ngày.\r\nThông báo: Hôm nay là thứ ..., tháng..., năm...\r\n");
                                                            testdateTimeEx.dateTime2();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\nBài3: Input: 1 ngày.\r\nThông báo: Hôm sau là thứ ..., tháng..., năm...\n");
                                                            testdateTimeEx.dateTime3();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\nBài4: Input: 1 ngày.\r\nThông báo: Hôm trước là thứ ..., tháng..., năm..\n");
                                                            testdateTimeEx.dateTime4();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("\nBài5: Input: 1 ngày.\r\nNếu là hôm nay -> Thông báo: Ngày hôm nay\r\nNếu là sau hôm nay -> Thông báo: Ngày tương lai\r\nNếu là trước hôm nay -> Thông báo: Ngày quá khứ\n");
                                                            testdateTimeEx.dateTime5();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 6:
                                                        {
                                                            Console.WriteLine("\nBài6: Nhập 1 ngày.\r\nHiển thị ngày dưới dạng: Ngày/tháng/năm. VD:18/03/2014\r\nHiển thị ngày dưới dạng: Năm/tháng/ngày. VD: 2014/03/18\r\nHiển thị ngày dưới dạng: Tháng/năm. VD: 03/2014\r\nHiển thị ngày dưới dạng: Tháng-năm. VD: 03-2014\n");
                                                            testdateTimeEx.dateTime6();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 7:
                                                        {
                                                            Console.WriteLine("\nBài7: Input: 1 ngày.\r\nHiển thị 10 ngày trước là thứ mấy\n");
                                                            testdateTimeEx.dateTime7();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 8:
                                                        {
                                                            Console.WriteLine("\nBài8: Input: 1 ngày.\r\nHiển thị cuối tháng này là thứ mấy\r\n");
                                                            testdateTimeEx.dateTime8();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 9:
                                                        {
                                                            Console.WriteLine("\nBài9: Input: 1 ngày.\r\nHiển thị cuối năm nay là thứ mấy\n");
                                                            testdateTimeEx.dateTime9();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 10:
                                                        {
                                                            Console.WriteLine("\nBài10: Input: 2 ngày.\r\nHiển thị 2 ngày này cách nhau bao nhiêu ngày\r\n\n");
                                                            testdateTimeEx.dateTime10();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }

                                    case 5:
                                        {
                                            int num2;
                                            boolEx testboolEx = new boolEx();
                                            do
                                            {
                                                Console.WriteLine("\nLựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Input: 1 chuỗi.\r\nNếu chuỗi là “true” hoặc “false” -> Chuyển thành kiểu bool và thông báo: Chuỗi hợp lệ.\r\nNgược lai -> Thông báo: Không phải chuỗi bool\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Input: 1 chuỗi.\r\nNếu chuỗi là “true” hoặc “false” -> Chuyển thành kiểu bool và thông báo: Chuỗi hợp lệ.\r\nNgược lai -> Thông báo: Không phải chuỗi bool\n");
                                                            testboolEx.bool1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }

                                    case 0:
                                        break;

                                    default:
                                        Console.WriteLine("Vui lòng nhập lại");
                                        break;
                                }
                            } while (num1 != 0);
                            break;
                        }

                    case 2:
                        {
                            int num1;
                            do
                            {
                                Console.WriteLine("Lựa chọn bài để kiểm tra: ");
                                Console.WriteLine("1.Dictionary\n" + "2.List\n");
                                Console.WriteLine("0.Nhập vào 0 để thoát.\n");
                                num1 = Convert.ToInt32(Console.ReadLine());
                                switch (num1)
                                {
                                    case 1:
                                        {
                                            dictionaryEx testdictEX = new dictionaryEx();
                                            int num2;
                                            do
                                            {
                                                Console.WriteLine("Lựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Tạo 1 Dictionary chứa key chưa mã Sinh viên kiểu int, value là Tên SV\r\nThêm vào Dictionary 5 giá trị\r\nTrả về Dictionary vừa tạo\n"
                                                                + "\nBài2: Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, in tên SV đó\r\nNgược lại thông báo: Không có SV có mã...\r\n\n"
                                                                + "\nBài3: Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thông báo: Đã có SV có mã...trong Dictonary\r\n\n"
                                                                + "\nBài4: Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thay tên SV cũ bằng tên SV mới, thông báo: Đã thay tên SV có mã...trong Dictonary từ... thành...\r\n\n"
                                                                + "\nBài5: Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, bỏ mã SV đó khỏi Dictionary\r\nNgược lại thông báo: Không có SV có mã...\r\n\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Tạo 1 Dictionary chứa key chưa mã Sinh viên kiểu int, value là Tên SV\r\nThêm vào Dictionary 5 giá trị\r\nTrả về Dictionary vừa tạo\n");
                                                            testdictEX.dict1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, in tên SV đó\r\nNgược lại thông báo: Không có SV có mã...\r\n\n");
                                                            testdictEX.dict2();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\nBài3: Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thông báo: Đã có SV có mã...trong Dictonary\r\n\n");
                                                            testdictEX.dict3();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\nBài4: Nhập 1 Dictionary, 1 mã SV và tên SV\r\nNếu mã SV đó chưa có trong Dictionary, thêm SV đó vào Dictionary, thông báo: Đã thêm \r\nSV có mã..., tên... vào Dictionary\r\nNgược lại thay tên SV cũ bằng tên SV mới, thông báo: Đã thay tên SV có mã...trong Dictonary từ... thành...\r\n\n");
                                                            testdictEX.dict4();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("\nBài5: Nhập 1 Dictionary, 1 mã SV\r\nNếu mã SV đó có trong Dictionary, bỏ mã SV đó khỏi Dictionary\r\nNgược lại thông báo: Không có SV có mã...\r\n\n");
                                                            testdictEX.dict5();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;

                                                }

                                            } while (num2 != 0);
                                            break;
                                        }
                                    case 2:
                                        {
                                            listEx testlistEX = new listEx();
                                            int num2;
                                            do
                                            {
                                                Console.WriteLine("Lựa chọn bài để kiểm tra: ");
                                                Console.WriteLine("\nBài1: Input: None\r\nTạo 1 danh sách số int\r\nThêm vào danh sách 10 số bất kỳ\r\nIn kết quả ra màn hình và trả về danh sách vừa tạo \n"
                                                                + "\nBài2: Input: danh sách 10 số bất kỳ\r\nSắp xếp danh sách theo thứ tự tăng dần, in kết quả ra màn hình\n"
                                                                + "\nBài3: Input: danh sách 10 số bất kỳ\r\nĐảo ngược vị trí các số trong danh sách, in kết quả ra màn hình\n"
                                                                + "\nBài4: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số nhỏ hơn X khỏi danh sách, in kết quả ra màn hình\n"
                                                                + "\nBài5: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số chia hết cho X khỏi danh sách, in kết quả ra màn hình\r\n\n"
                                                                + "\nBài6: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nVới mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X\r\nIn kết quả ra màn hình\n"
                                                                + "\nBài7: Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình\n"
                                                                + "\nBài8: Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại\r\n"
                                                                + "\nBài9: Input: 1 số lớn hơn 0 (X)\r\nTính dãy Fibonaci của số nhập vào\r\nIn 10 giá trị kết quả ra màn hình\r\nTrả về dãy đã tạo\n"
                                                                + "\n0.Nhập vào 0 để chọn mục khác.\n"
                                                                );
                                                num2 = Convert.ToInt32(Console.ReadLine());
                                                switch (num2)
                                                {
                                                    case 1:
                                                        {
                                                            Console.WriteLine("\nBài1: Input: None\r\nTạo 1 danh sách số int\r\nThêm vào danh sách 10 số bất kỳ\r\nIn kết quả ra màn hình và trả về danh sách vừa tạo \n");
                                                            testlistEX.list1();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 2:
                                                        {
                                                            Console.WriteLine("\nBài2: Input: danh sách 10 số bất kỳ\r\nSắp xếp danh sách theo thứ tự tăng dần, in kết quả ra màn hình\n");
                                                            testlistEX.list2();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 3:
                                                        {
                                                            Console.WriteLine("\nBài3: Input: danh sách 10 số bất kỳ\r\nĐảo ngược vị trí các số trong danh sách, in kết quả ra màn hình\n");
                                                            testlistEX.list3();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 4:
                                                        {
                                                            Console.WriteLine("\nBài4: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số nhỏ hơn X khỏi danh sách, in kết quả ra màn hình\n");
                                                            testlistEX.list4();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 5:
                                                        {
                                                            Console.WriteLine("\nBài5: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nBỏ đi các số chia hết cho X khỏi danh sách, in kết quả ra màn hình\r\n\n");
                                                            testlistEX.list5();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 6:
                                                        {
                                                            Console.WriteLine("\nBài6: Input: danh sách 10 số bất kỳ và 1 số (X)\r\nVới mỗi số trong danh sách, nếu nhỏ hơn X thì cộng với X\r\nIn kết quả ra màn hình\n");
                                                            testlistEX.list6();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 7:
                                                        {
                                                            Console.WriteLine("\nBài7: Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình\n");
                                                            testlistEX.list7();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 8:
                                                        {
                                                            Console.WriteLine("\nBài8: Input: danh sách 10 số bất kỳ và 1 số lớn hơn 0 (X)\r\nIn X số cuối ra màn hình theo chiều ngược lại\r\n\n");
                                                            testlistEX.list8();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 9:
                                                        {
                                                            Console.WriteLine("\nBài9: Input: 1 số lớn hơn 0 (X)\r\nTính dãy Fibonaci của số nhập vào\r\nIn 10 giá trị kết quả ra màn hình\r\nTrả về dãy đã tạo\n");
                                                            testlistEX.list9();
                                                            Console.ReadLine();
                                                            break;
                                                        }
                                                    case 0:
                                                        break;
                                                    default:
                                                        Console.WriteLine("Vui lòng nhập lại");
                                                        break;
                                                }
                                            } while (num2 != 0);
                                            break;
                                        }
                                    case 0:
                                        break;
                                    default:
                                        Console.WriteLine("Vui lòng nhập lại");
                                        break;
                                }

                            } while (num1 != 0);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Tạo class Employee chứa field: Tên, Tuổi, Thời gian tạo và 2 method là ShowInfo() và \r\nExtInfo().\r\nTạo class Student kế thừa Employee và bổ sung thêm field Chuyên ngành.\r\nTạo class Teacher kế thừa Employee và bổ sung thêm field Bộ môn\r\nTrong đó: \r\n+ ShowInfo(): Hiện thị thông tin\r\n- Nếu là Người: \"Tôi tên là ..., ... tuổi.\"\r\n- Nếu là Sinh Viên: \"Tôi tên là ..., ... tuổi. Tôi là Sinh Viên\"\r\n- Nếu là Giáo Viên: \"Tôi là Giáo Viên, ... tuổi, tôi tên là ...\"\r\n+ ExtInfo(): Hiển thị\r\n- Nếu là Người: \"Tôi tên là ..., được tạo ra lúc…\" (hiển thị đến giây)\r\n- Nếu là Sinh Viên: \"Tôi là Sinh viên tên ..., học chuyên ngành…, được tạo ra lúc…\"\r\n- Nếu là Giáo Viên: \"Tôi là Giáo Viên tên..., thuộc bộ môn…, được tạo ra lúc…\"\r\n");
                            Employee emp = new Employee();
                            Console.WriteLine("Nhập vào tên SV:");
                            var name = Console.ReadLine();
                            Console.WriteLine("Nhập vào tuổi SV:");
                            var age = Convert.ToInt32(Console.ReadLine());
                            emp.Name = name;
                            emp.Age = age;
                            emp.Date = DateTime.Now;
                            emp.ShowInfo();
                            emp.ExtInfo();
                            Console.WriteLine("\n");

                            Teacher teach = new Teacher();
                            Console.WriteLine("Nhập vào tên GV:");
                            var name1 = Console.ReadLine();
                            Console.WriteLine("Nhập vào tuổi GV:");
                            var age1 = Convert.ToInt32(Console.ReadLine());
                            teach.Name = name1;
                            teach.Age = age1;
                            teach.Date = DateTime.Now;
                            teach.Subject = "Toán";
                            teach.ShowInfo();
                            teach.ExtInfo();
                            Console.WriteLine("\n");
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("Nhập đường dẫn đến 1 file đầu vào và 1 file đầu ra.\r\nCấu trúc file đầu vào: mỗi dòng là 1 dãy số kiểu Int32 cách nhau bởi 1 hoặc nhiều dấu space\r\nVí dụ: 123 456 7634 2334 567\r\nYêu cầu:\r\nTạo file đầu ra theo cấu trúc:\r\n- Số dòng của file đầu ra bằng số dòng của file đầu vào\r\n- Với mỗi dòng của file đầu vào, sắp xếp dãy số theo thứ tự giảm dần và ghi vào một dòng của \r\nfile đầu ra theo định dạng mỗi số cách nhau bởi 04 dấu space\r\n- Nếu dãy số trong dòng dữ liệu của file đầu vào lỗi thì ghi vào file đầu ra thông báo lỗi\r\n+ Số [số bị sai] bị sai format (không phải kiểu Int32)\r\n+ Số [số vượt giới hạn] bị vượt giới hạn kiểu Int32\r\n- Nếu có bất kỳ lỗi nào xảy ra khi mở file đầu vào để đọc, ghi ra file đầu ra 01 dòng với nội \r\ndung “Không đọc được file đầu vào. Lý do: [thông báo nguyên nhân lỗi]”");
                            Console.WriteLine("\nNhập vào đường dẫn file đầu vào:");
                            var filepath1 = Console.ReadLine();
                            Console.WriteLine("Nhập vào đường dẫn file đầu ra:");
                            var filepath2 = Console.ReadLine();
                            FileEx file = new FileEx();

                            file.filePath1 = filepath1;
                            file.filePath2 = filepath2;
                            file.DataStorage();
                            break;
                        }

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Vui lòng nhập lại");
                        break;
                }
            } while (num != 0);
        }
    }
}

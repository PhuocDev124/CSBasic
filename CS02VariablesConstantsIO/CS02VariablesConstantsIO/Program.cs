// Các kiểu dữ liệu cơ bản:
/*
 * số nguyên:
 *  - byte;
 *  - int;
 *  - short;
 *  - long;
 *  Số thực:
 *  - float
 *  - double;
 *  - decimal
 *  Kí tự:
 *  - char;
 *  Logic:
 *  - bool
 *  Chuỗi:
 *  - String
 *  Đối tượng:
 *  - object
 */

// xuất dữ liệu ra màn hình console:
/*
    Console.Write(value);
    Console.WriteLine(value);
    Console.ForegroundColor = ConsoleColor.[Red] ==> màu chữ
    Console.ResetColor()
 */

// Nhập dữ liệu
/*
    Console.ReadLine() ==> Cho phép nhập dữ liệu đến khi nhấn Enter
    Console.ReadKey() ==> Cho phép nhập một kí tự 
 */

//Chuyễn kiểu dữ liệu: dữ liệu nhập vào từ Console.ReadLine() là string ==> sử dụng lớp Convert để chuyển đổi
/*
    Convert.ToInt32(value)      ==> chuyển thành kiểu int
    Convert.ToDouble(value)     ==> chuyển thành kiểu double
    Convert.ToBoolean(value)    ==> chuyển thành kiểu bool
 */
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello Everyone");
Console.ResetColor();
Console.Write("Your Name: ");
Console.ForegroundColor = ConsoleColor.DarkMagenta; // magenta :màu tím
string name = Console.ReadLine();
Console.ResetColor();
Console.Write("Year of birth: ");
Console.ForegroundColor = ConsoleColor.Green;
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.ForegroundColor= ConsoleColor.Blue;
Console.WriteLine($"Your information: {name}, {DateTime.Now.Year - yearOfBirth} years old");
Console.ResetColor();

/*
    Phương thức (Method) là một nhóm lệnh nhầm thực hiện một yêu cầu nào đó
    Cú pháp khai báo:
    -   <Access_Modifier> <Return_Type> <Name_Method>(<Parameters>)
    +   Access_Modifier (Phạm vi truy cập)
        --> public      ==> anywhere
        --> internal    ==> cùng một assembly(dự án)
        --> protected   ==> subclass
        --> private     ==> in class
    + Return_type(kiểu dữ liệu trả về): void int string ...
    + Name_Method: Tên phương thức
    + Parameters: Các tham số truyền vào method
 */

// Calculate the square of a number
using CS07Method;

int Square(int n)
{
    return n * n;
}

Console.WriteLine(Square(4)); // 16

//Tham chiếu (pass by reference: key (ref , out)) và tham trị (pass by value)
static int passByValue(int x)
{
    x *= x;
    return x;
}

static int passByReference(ref int x)
{
    x *= x;
    return x;
}

int a = 2;
int b = 2;

Console.WriteLine("a: "+ a);                        // a = 2
Console.WriteLine("resultA: " + passByValue(a));    // resultA = 4
Console.WriteLine("a: " + a);                       // a = 2
Console.WriteLine("----------------------------");
Console.WriteLine("b: " + b);                               //b = 2 
Console.WriteLine("resultB: " + passByReference(ref b));    //resultB = 4
Console.WriteLine("b: " + b);                               //b = 4

//Đệ quy (Recursion): là một hàm tự gọi lại chính nó
static int FactorialRecursion(int n)
{
    if (n == 1 || n == 0)
        return 1;
    else
        return FactorialRecursion(n - 1) * n;
}

Console.WriteLine("========================================");
Console.WriteLine("5! = " + FactorialRecursion(5)); // 120

CS07Test test = new CS07Test();
Console.WriteLine(test.sumOfDigits(1234));
Console.WriteLine(test.Power(2, 3));
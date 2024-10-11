//Toán tử so sánh (Comparison Operator): == > >= < <= != 
//Toán tử logic (Logical Operator): && || !
//Câu lệnh If: If() {} else {}
//Toán tử 3 ngôi: condition? resultIfTrue : resultIfFalse
//Câu lệnh switch: 

void printmessage(string mess) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mess);
    Console.ResetColor();
}

//bài 1: Kiểm tra số chẵn lẻ (Even or Odd)
printmessage("Check whether the entered number is an even or odd");
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
    Console.WriteLine($"{n} is an even");
else
    Console.WriteLine($"{n} is an odd");

//Bài 2: Kiểm tra năm nhuần (check leap year)
/*
 * chia hết cho 4 nhưng không chia hết cho 100 hoặc
 * chia hết cho 400
 */
printmessage("Check Leap year");
Console.Write("Enter a Year: ")
int year = Convert.ToInt32(Console.ReadLine());
if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
    Console.WriteLine($"{year} is leap year");
else
    Console.WriteLine($"{year} is not leap year");
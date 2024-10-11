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

//Kiểm tra ngày hợp lệ (Check for valid dates)
printmessage("Check for valid dates");
Console.Write("Enter a day: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a month: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0 ? true : false);
bool isValidDate = true;

if (month < 1 || month > 12)
    isValidDate = false;
else
{
    switch (month)
    {
        case 1: case 3:case 5: case 7: case 8: case 10: case 12:
            if (day < 1 || day > 31) isValidDate = false; 
            break;
        case 4: case 6: case 9: case 11:
            if (day < 1 || day > 30) isValidDate = false;
            break;
        case 2:
            if (isLeapYear && (day < 1 || day > 29)) isValidDate = false;
            if (!isLeapYear && (day < 1 || day > 28)) isValidDate = false;
            break;
    }
}

if (isValidDate)
    Console.WriteLine($"{day}/{month}/{year} is valid date");
else
    Console.WriteLine($"{day}/{month}/{year} is not valid date");
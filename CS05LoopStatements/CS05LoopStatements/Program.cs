//for loop
//foreach loop
//while loop
//do..while loop
//continue
//break

//in số nguyên tố trong khoảng [1:100] (check prime number)
for (int i = 1; i < 101; i++)
{
    if (i < 4 || (i % 2 != 0 && i % 3 != 0))
        Console.Write(i + "\t");
}

//tìm số Fibonaccy (find Fibonaccy number)
Console.Write("\nEnter a number you want to calculate the fibonaccy number: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
int result = 0;
if (n == 0)
    result = 0;
else if (n == 1)
    result = 1;
else
    for (int i = 2; i <= n; i++)
    {
        result = a + b;
        a = b;
        b = result;
    }
Console.WriteLine(result);

// tính giai thừa (calculate factorial)
int factorial = 1;
for (int i = 1; i <=  n; i++)
{
    factorial *= i;
}
Console.WriteLine($"{n}! = {factorial}");
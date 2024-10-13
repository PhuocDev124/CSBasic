using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS07Method
{
    internal class CS07Test
    {
        //tính tổng các chữ số của một số nguyên
        public int sumOfDigits(int n)
        {
            if (n == 0)
                return 0;
            else 
                return sumOfDigits(n / 10) + n % 10;
        }

        //tính lũy thừa của một số
        public int Power(int n, int x)
        {
            if (x == 0)
                return 1;
            else
                return n * Power(n, x - 1);
        }
    }
}

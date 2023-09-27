using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.EmelianovaKP.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("The variable b = {0}. You can't divide by 0.", b);
                return -1;
            }

            return a / b;
        }
    }
}

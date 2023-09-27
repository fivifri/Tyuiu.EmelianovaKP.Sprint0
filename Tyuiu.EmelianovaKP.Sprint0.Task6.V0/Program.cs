using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint0.Task6.V0.Lib;

namespace Tyuiu.EmelianovaKP.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arraynums = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("The Array elements sum = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("The Array elements difference = " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("The Array elements product = " + DataService.MultiplicationArray(arraynums));

            Console.ReadKey();
        }
    }
}

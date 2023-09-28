using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.EmelianovaKP.Sprint0.TaskReview.V0.Lib;
namespace Tyuiu.EmelianovaKP.Sprint0.TaskReview.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 4;
            int z = 10;

            Console.WriteLine($"x = {x}, y = {y}, z = {z}. The result is {DataService.Calc(x, y, z)}.");

            Console.ReadKey();
        }
    }
}

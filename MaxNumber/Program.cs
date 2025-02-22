using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("введите третье число: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int maxNumber = Math.Max(num1, Math.Max(num2, num3)); //сравнивает сначало num2 и num3 а потом nam1 (это без использовани  if)

            Console.WriteLine($"наибольшее число: {maxNumber}");
        }
    }
}

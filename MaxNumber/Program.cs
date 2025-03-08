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
            Console.WriteLine("введите количесто элементов массива: ");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Ввод элементов массива: {i + 1}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int maxElement = array[0];

            for (int i = 0; i < length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            Console.WriteLine($"наибольшее число: {maxElement}");
        }
    }
}

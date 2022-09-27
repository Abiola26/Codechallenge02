using Codechallenge02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChange02
{
    class program
    {
        static void Main(String[] args)
        {
            BothSum arraySum = new BothSum();

            Console.WriteLine("Enter the size of the array");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            Console.WriteLine("Enter the elements of the array");


            int sum = arraySum.SumArray(array);
            Console.WriteLine($"The input array");
            foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"The sum of largest and smallest is {sum}");
        }
    }
}

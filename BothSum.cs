using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codechallenge02
{
    public class BothSum
    {
        public int SumArray(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int smallest = array[0];
            int Largest = array[0];
            for (int i = 0; i < length; i++)
            {
                if (smallest > array[i])
                {
                    smallest = array[i];
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (Largest < array[i])
                {
                    Largest = array[i];
                }
            }

            int sum = Largest + smallest;

            return sum;
        }
    }
}

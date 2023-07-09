using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Second_Smalest
    {// WAP to find the second smallest element in an array.
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            Console.WriteLine("enter array elements");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Second smallest " + arr[1]);
        }
    }
}

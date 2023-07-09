using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Unique
    {
        static void Main(string[] args)
        {
            //WAP to print all unique elements in the array.
            int[] arr = new int[10];
            Console.WriteLine("Enter elements of an array");
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Number of Duplicate elements are");
            for (int i = 0; i < arr.Length; i++)
            {

                //int a = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        Console.WriteLine(arr[j]);
                        count++;
                    }
                }



                Console.WriteLine("\n\nno of duplicate elements" + count);

            }
        }
    }
}

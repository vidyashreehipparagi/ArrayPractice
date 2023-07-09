using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Negative
    {// WAP to print all negative elements in an array
     // and also count total number of negative elements in an array.
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int count = 0;
            Console.WriteLine("Enter array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
             }
            Console.WriteLine("Negative numbers are");
            for (int i = 0; i < arr.Length; i++)

            {
                if (arr[i]<0) {
                    count++;
                    
                    Console.Write(" "+arr[i]);

                }
                
            }

            Console.WriteLine("\nNumber of negative elements are "+count);

        }
    }
}

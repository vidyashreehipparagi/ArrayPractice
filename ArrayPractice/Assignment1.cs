using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            //     WAP to search for a given number in an array
             ////      and accordingly print the index if exists
             
            int[] arr = new int[5];
            Console.WriteLine
                ("Enter array");
            for (int i = 0; i < arr.Length; i++)
            {
               
                arr[i] = Convert.ToInt32(Console.ReadLine());
              
                

            }

            Console.WriteLine("Enter element to search");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    Console.WriteLine($"index={i}");
                }
            }

            
        
        }
    }
}

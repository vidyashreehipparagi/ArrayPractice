using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Max_Min
    {//      WAP to find the maximum and minimum value in an array.
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int max ;
            int min ;

            Console.WriteLine("Enter array");

            for (int i = 0; i < arr.Length; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            max = arr[0];
            min = arr[0];
            for (int i = 0; i <arr.Length; i++)

            {  // max = 0;
               // min = 0;
                if (arr[i] > max)
                {
                    max = arr[i];
                    
                }
              else if (arr[i] < min )
                {
                    min = arr[i];
                    
                }

               }
              Console.WriteLine($"Max Value is {max}");
             Console.WriteLine($"Min Value is {min}");

           
            
            
            
             }
    }
}

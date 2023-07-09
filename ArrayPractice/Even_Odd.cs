using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice { 


    internal class Even_Odd
    {//WAP to put even and odd elements of array in two separate arrays.
        static void Main(string[] args)
        {
            int[] arr = new int[6];
           int count1 = 0,count2=0;

            Console.WriteLine("Enter array elements");
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nEven numbers are : ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0){
                    Console.Write( arr[i]+" ");
                    count1++;
                }
               
            }
            Console.Write("\n\nOdd numbers are : ");
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i]+" ");
                    count2++;
                }

            }
            Console.WriteLine("\n\n\nNo of even numbers: "+count1++);
            Console.WriteLine("\nNumber of odd numbers: "+count2+++"\n");

        }
    }
}

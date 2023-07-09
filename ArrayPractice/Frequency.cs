using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ArrayPractice
{
    internal class Frequency
    {
        static void Main(string[] args)
        {
            // WAP to count frequency of each element in an array.
            int[]arr=new int[6];
            int count = 0;
            Console.WriteLine("Enter elements of an array");
           
            for (int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter number to be search");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("No= " + count);
            Console.WriteLine(num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    internal class Merge2Array
    {// WAP to merge 2 arrays to 3rd array. 3rd array should not have elements of same value.
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 2,3,5,4,6,8 };
            int[] c = new int[] { };
            int i,j;

            Console.WriteLine("Elements of first array are");
            for ( i = 0; i <a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("Elemets of second array are");
            for ( i=0; i <b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            j = i;
          
            for ( i = 0; i <=a.Length+b.Length; i++,j++)
            {
                c[i]= a[i];
                Console.WriteLine(c[i]);
            }
            

        }
    }
}

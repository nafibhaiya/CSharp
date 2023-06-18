using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1D array________

            int[] a = new int[3] { 1, 2, 3 };



            /*byte x = 0;
            while (x < a.Length)
            {
                Console.WriteLine("{0} ", a[x]);    // show with while loop
                x++;
            }*/



            /* for(int i = 0; i <a.Length; i++)
             {
                 Console.WriteLine("{0}",a[i]);     // with for loop
             }*/



            /* byte c = 0;
            do
            {
                Console.WriteLine(a[c]);            //with do while loop
                c++;
            }
            while (c < a.Length);*/
           
            foreach (int i in a)
            {
                Console.WriteLine("{0}", i);
            }



            //2D or multi D array___________ 

            int[,] m = new int[3,3] { { 1 ,2, 3 }, { 4,5,6}, { 7,8,9 } };

/*
            byte r = 0;
            while (r < m.Length)
            {
                byte c = 0;

                while (c < 3)
                {
                    Console.Write("{0} ", m[r, c]);       //to show in matrix form .Write()
                    c++;

                }
                Console.WriteLine();
                r++;

            }*/


                        //**************JAGGED ARRAY **************

            int[][] ja= new int[4][];       //only provide row value

 /*           ja[0] = new int[2] { 1, 2 };
            ja[1] = new int[4] { 5, 2,6,7 };        //array in array 
            ja[2] = new int[3] { 4, 5, 3 };
            ja[3] = new int[4] {11,2,3,4 };

            byte r = 0; 
            while(r<ja.Length)
            {
                byte c = 0;
                while (c < ja[r].Length)            //ja[r].length
                {
                    Console.Write("{0} ",ja[r][c]);
                    c++;
                }
                Console.WriteLine();
                r++;
            }*/



        }
    }
}

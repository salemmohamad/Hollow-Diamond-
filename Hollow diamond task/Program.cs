using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_diamond_task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter odd number ");
            int x = int.Parse(Console.ReadLine());
            int a, b, i, j, m, n;
            if (x % 2 == 1)
            {
                // """"""""""""""""""""""""""""""""""first triangle"""""""""""""""""""""""""""""""""""""""""""""""""""""
                //first row
                for (a = 1; a <= x - 1; a++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");//the star at the top
                Console.WriteLine("");

                //rest of triangle
                for (m = 1; m <= x - 1; m++)
                {
                    for (b = 1; b <= x - 1 - m; b++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");//the star at the begining off each row
                    for (n = 1; n <= (2 * m) - 1; n++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");//the star at the end of each row
                    Console.WriteLine("");//new line
                }

                //"""""""""""""""""""""""""""""""""""second triangle""""""""""""""""""""""""""""""""""
                for (a = 1; a <= x - 2; a++)
                {
                    for (m = 1; m <= a; m++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");//the star at the begining off each row
                    for (b = 1; b <= (2 * x) - 3 - (2 * a); b++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");//the star at the end of each row
                    Console.WriteLine("");//new line

                }
                //the last row
                for (n = 1; n <= x - 1; n++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");//the single star at the bottom
            }
            else
            {
                Console.WriteLine("please enter odd number !! ");
            }

           Console.ReadKey();
        }
    }
}

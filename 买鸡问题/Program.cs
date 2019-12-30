using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 100; a++)
            {
                for (int b = 0; b <= 100; b++)
                {
                    for (int c = 0; c <= 100; c++)
                    {
                        int w = a * 5 + b * 3 + c / 3;
                        int y = a + b + c;
                        if (w == 100 && y == 100 && c % 3 == 0)
                        {

                            Console.WriteLine("{0}{1}{2}", a, b, c);
                        }
                    }
                }
            }
            Console.Read();
        }
        
    }
}

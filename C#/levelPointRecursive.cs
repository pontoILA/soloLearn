using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
        }

        
        static int Points(int levels)
        {
            //your code goes here
            return levels==1? 1:Points(levels-1)+levels;

        }

    }

}

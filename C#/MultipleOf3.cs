using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            //your code goes here
            for(int i=1;i<=number; i++){
                Console.Write(i%3==0?"*":Convert.ToString(i));
            }
            
        }
    }
}

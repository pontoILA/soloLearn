using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
            double ddiscount = discount;
            foreach(string name in coffee.Keys.ToArray()){
                int new_value = (int)(coffee[name]*(1-(ddiscount/100))+0.5);//0,5 is for rounding
                Console.WriteLine(name+": "+new_value);
            }


        }
    }
}

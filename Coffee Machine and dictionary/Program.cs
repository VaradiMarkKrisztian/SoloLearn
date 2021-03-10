using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Machine_and_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d =new Dictionary<string,int>();
            d.Add("John", 24);
            d.Add("Ann", 18);
            d.Add("Peter", 27);
            string name = "John";
            Console.Write(d[name]);
            Console.ReadKey();

            int discount = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);
            //your code goes here
            foreach (string drink in coffee.Keys.ToArray())
            {
                coffee[drink] = coffee[drink] - (coffee[drink] * discount) / 100;
                Console.WriteLine($"{drink}: {coffee[drink]}");
            }
            Console.ReadKey();
        }
    }
}

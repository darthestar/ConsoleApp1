using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {


        static void Main(string[] args)
        {

            int dogs = 5;
            int sandwiches = 1;
            double cost = 80.00;
            string carColor = "steel blue";
            string carMake = "Aston Martin";
            string carModel = "convertable";
            char firstInitial = 'D';
            long starsInTheSky = 100_000_000_000_000_000;
            DateTime date = DateTime.Now;

            Console.WriteLine("There are " + dogs + " dogs running around a dog park");


            Console.WriteLine("The number of sandwiches I can eat is: " + sandwiches + "when I am hungry");


            Console.WriteLine("The amount of money it costs to buy a nice dinner is: " + cost);

            Console.WriteLine("The color " + carColor + "is the color of my dream car");
            
            Console.WriteLine("My dream car is a " + carModel + " model");
            Console.WriteLine("My dream car is a " + carMake + " make");
            Console.WriteLine("The first letter of my name is: " + firstInitial);
            Console.WriteLine("The number of stars in the sky is: " + starsInTheSky);

            Console.WriteLine("Today's date is : " +  date);
            Console.ReadLine();


        }
    }
}

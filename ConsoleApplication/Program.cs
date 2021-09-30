using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string location;
            
            // Get info from user
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Where are you from? ");
            location = Console.ReadLine();

            //Write to console
            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You are from: {location}");

            // Current Date
            var currentDate = DateTime.Now;
            var day = currentDate.ToLongDateString();
            Console.WriteLine($"Today's date is {day}");
            var day1 = currentDate.Date;

            var christmas = new DateTime(currentDate.Year, 12, 25).Date;
            Console.WriteLine(christmas);

            var daysTilChristmas = (int)(christmas - day1).TotalDays;
            Console.WriteLine($"There are {daysTilChristmas} days til Christmas.");


            //Initializing variables
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //Getting variables from the user
            Console.Write("What is the width of the window? ");
            widthString = Console.ReadLine();
            Console.Write("What is the height of the window? ");
            heightString = Console.ReadLine();
            
            width = double.Parse(widthString);
            height = double.Parse(heightString);
            
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            
            Console.WriteLine("The length of the wood is " +
                   woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
                   glassArea + " square metres");


            Console.ReadKey();


        }
    }
}

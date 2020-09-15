using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            string name, location;
            int daysToXmas;


            //Get Name and State
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your state/country: ");
            location = Console.ReadLine();


            //Output Name & Location
            Console.WriteLine(String.Format("\nMy Name is {0}, I am from {1}.", name, location));

            //Output Date in custom format
            Console.WriteLine("\nToday Date: " + DateTime.Now.ToString("MM/dd/yyyy"));

            //Calculate days to Christmas
            daysToXmas = (new DateTime(2020, 12, 25).DayOfYear) - DateTime.Now.DayOfYear;
            Console.WriteLine(String.Format("\nDays to Christmas: {0}", daysToXmas));

            //Call Method for GlazerCalc from 2.1 Section
            GlazerCalc();

            //Pause and wait for input before closing
            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();

        }


        /// <summary>
        /// GlazerClac section 2.1 method
        /// </summary>
        static void GlazerCalc()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("\nPlease enter the width (Metres):");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height (Metres):");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}

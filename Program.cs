// See https://aka.ms/new-console-template for more information

namespace Application
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Cost Visualiser Program.");
            Console.WriteLine("To start, please enter your currency symbol.");
            Console.WriteLine("Do not enter the full name of the currency you wish to use");

            string currencySymbol = Console.ReadLine();

            while (currencySymbol.Length != 1)
            {
                Console.WriteLine("Invalid response. Please try again.");
                currencySymbol = Console.ReadLine();
            }

            Console.WriteLine("Next, please enter your hourly rate");

            try
            {
                double hourlyRate = float.Parse(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("An error occurred. Please retry.");
            }
            

            Console.WriteLine("Finally, what is the cost of the item/service you wish to purchase?");

            double costOfProduct = Math.Round(float.Parse(Console.ReadLine()), 2);

            double hoursOfWorkRequired = costOfProduct / hourlyRate;

            double minutesOfWorkRequired = Math.Round(hoursOfWorkRequired * 60);

            // multiplication by 60 here to get convert the figure into minutes instead of hours.
            // this will make subsequent calculations easier. 

            double leftoverHours = minutesOfWorkRequired % 60;

            if (minutesOfWorkRequired < 1 && costOfProduct != hourlyRate)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                // displays the text in a dark green colour
            }

            else
            {
                if (hoursOfWorkRequired <= 25)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                    // displays the text in a dark green colour
                }

                else if (hoursOfWorkRequired > 25 && hoursOfWorkRequired <= 50)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                    // displays the text in a standard green colour
                }

                else if (hoursOfWorkRequired > 50 && hoursOfWorkRequired <= 75)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                    // displays the text in a dark yellow colour
                }

                else if (hoursOfWorkRequired > 75 && hoursOfWorkRequired <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                    // displays the text in a red colour
                }

                else if (hoursOfWorkRequired > 100)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{Math.Round(costOfProduct, 2)}");
                    // displays the text in a dark red colour
                }

            }

            
        }
    }
}

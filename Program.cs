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

            double hourlyRate = float.Parse(Console.ReadLine());

            Console.WriteLine("Finally, what is the cost of the item/service you wish to purchase?");

            double costOfProduct = float.Parse(Console.ReadLine());

            double hoursOfWorkRequired = costOfProduct / hourlyRate;

            double minutesOfWorkRequired = Math.Round(hoursOfWorkRequired * 60);

            // multiplication by 60 here to get convert the figure into minutes instead of hours.
            // this will make subsequent calculations easier.

            double leftoverHours = minutesOfWorkRequired % 60;

            if (leftoverHours == 0)
            {
                Console.WriteLine($"It will take you less than one minute of work to provide {currencySymbol}{costOfProduct}");
            }

            else
            {
                Console.WriteLine($"It will take you {(int)hoursOfWorkRequired} hours and {leftoverHours} minutes of work to provide {currencySymbol}{costOfProduct}");
            }

            
        }
    }
}

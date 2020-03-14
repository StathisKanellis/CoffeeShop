using System;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalCoffeCost = 0d;
            string UserDecision = string.Empty;
            do
            {
                string UserChoice = string.Empty;
                int Result = 0;
                do
                {
                    Console.WriteLine("Please select your coffee size: 1 - Small 1.10E, 2 - Medium 1.90E, 3 - Large 2.50E");
                    UserChoice = Console.ReadLine();
                    bool UserChoiceCheck = int.TryParse(UserChoice, out Result);

                    if (UserChoiceCheck)
                    {
                        switch (Result)
                        {
                            case 1:
                                TotalCoffeCost += 1.1;
                                break;
                            case 2:
                                TotalCoffeCost += 1.9;
                                break;
                            case 3:
                                TotalCoffeCost += 2.5;
                                break;
                            default:
                                Console.WriteLine($"Your choice: {Result} is invalid");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Your choice: {UserChoice} is invalid. Please try again.. ");
                    }
                } while (Result != 1 && Result != 2 && Result != 3);
                do
                {
                    Console.WriteLine("Do you want to buy another coffee - Yes or No?");
                    UserDecision = Console.ReadLine().ToUpper();

                    if (UserDecision != "YES" && UserDecision != "NO")
                    {
                        Console.WriteLine($"Your choice: {UserDecision} is invalid. Please try again..");
                    }
                } while (UserDecision != "YES" && UserDecision != "NO");
            } while (UserDecision.ToUpper() != "NO");

            Console.WriteLine("Thank you for shopping with us!!");
            Console.WriteLine($"Bill Amount = {TotalCoffeCost} euro");
        }
    }
}
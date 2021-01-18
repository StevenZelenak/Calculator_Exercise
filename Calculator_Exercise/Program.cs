using System;

namespace Calculator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Put in one of the following symbols to determine what you would like to do with the calculator ( + / ^ * avg)\n");
            var mathSymbol = Console.ReadLine();

            Console.WriteLine("Please Enter the numbers you would like to use in the following format: number, number, number");
            string numberAsString = Console.ReadLine();
            string[] numbersArray = numberAsString.Split(",");

            // Variables
            bool grabFirstNum = false;
            int prevNumber = 0;

            switch (mathSymbol.ToLower())
            {
                case "+":
                    foreach (var sub in numbersArray)
                    {
                        //Addition
                        var numberSub = int.Parse(sub);
                        if (!grabFirstNum)
                        {
                            prevNumber = numberSub;
                            grabFirstNum = true;
                        }
                        else
                        {
                            prevNumber = prevNumber + numberSub;
                            
                        } 
                    }
                    Console.WriteLine($"Your total is equal to {prevNumber}");
                    break;
                case "/":
                    foreach (var sub in numbersArray)
                    {
                        //Addition
                        var numberSub = int.Parse(sub);
                        if (!grabFirstNum)
                        {
                            prevNumber = numberSub;
                            grabFirstNum = true;
                        }
                        else
                        {
                            prevNumber = prevNumber / numberSub;

                        }
                    }
                    Console.WriteLine($"Your total is equal to {prevNumber}");
                    break;
                case "^":
                    foreach (var sub in numbersArray)
                    {
                        //SQUARE
                        var numberSub = int.Parse(sub);
                        Console.WriteLine($"{sub} squared is equal to {numberSub * numberSub}");
                    }
                    break;
                case "*":
                    foreach (var sub in numbersArray)
                    {
                        //Addition
                        var numberSub = int.Parse(sub);
                        if (!grabFirstNum)
                        {
                            prevNumber = numberSub;
                            grabFirstNum = true;
                        }
                        else
                        {
                            prevNumber = prevNumber * numberSub;

                        }
                    }
                    Console.WriteLine($"Your total is equal to {prevNumber}");
                    break;
                case "avg":
                    foreach (var sub in numbersArray)
                    {
                        //Addition
                        var numberSub = int.Parse(sub);
                        if (!grabFirstNum)
                        {
                            prevNumber = numberSub;
                            grabFirstNum = true;
                        }
                        else
                        {
                            prevNumber = prevNumber + numberSub;

                        }
                    }
                    prevNumber = prevNumber / numbersArray.Length;
                    Console.WriteLine($"Your total is equal to {prevNumber}");
                    break;
                default:
                    Console.WriteLine("You didn't pick one!");
                    break;
            }

            

            

        }
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Money Maker!");
Console.WriteLine("Please enter an amount to convert to coins:");
string userCoinAmount = Console.ReadLine();
double convertCoinAmount = Convert.ToDouble(userCoinAmount);
Console.WriteLine($"{convertCoinAmount} cents is equal to...");
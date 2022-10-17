// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Money Maker!");
Console.WriteLine("Please enter an amount to convert to coins:");
string userCoinAmount = Console.ReadLine();
double convertCoinAmount = Convert.ToDouble(userCoinAmount);
Console.WriteLine($"{convertCoinAmount} cents is equal to...");
int goldValue = 10;
int silverValue = 5;
double goldCoins = Math.Floor(convertCoinAmount / goldValue);
double leftOver = convertCoinAmount % goldValue;
double silverCoins = Math.Floor(leftOver / silverValue);
leftOver = leftOver % silverValue;
Console.WriteLine($"Gold coins: {goldCoins}");
Console.WriteLine($"Silver coins: {silverCoins}");
Console.WriteLine($"Bronze coins : {leftOver}");
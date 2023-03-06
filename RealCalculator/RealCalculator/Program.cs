Console.WriteLine("Welcome To The Real Calculator Application");

Console.WriteLine("Please enter your first number");
string numberOne = Console.ReadLine();
int parsedNumberOne = int.Parse(numberOne);

Console.WriteLine("Please enter your second number");
string numberTwo = Console.ReadLine();
int parsedNumberTwo = int.Parse(numberTwo);

Console.WriteLine("Which of the following operators would you like to use: +, -, /, *");
Console.ReadLine();

int calculatedNums = (parsedNumberOne + parsedNumberTwo);
Console.WriteLine(calculatedNums);
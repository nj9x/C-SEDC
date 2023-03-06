Console.WriteLine("Average Number");

Console.WriteLine("Please enter your first number:");
string firstNumber = Console.ReadLine();
int numberOne = Convert.ToInt32(firstNumber);


Console.WriteLine("Please enter your second number:");
string secondNumber = Console.ReadLine();
int numberTwo = Convert.ToInt32(secondNumber);

Console.WriteLine("Please enter your third number:");
string thirdNumber = Console.ReadLine();
int numberThree = Convert.ToInt32(thirdNumber);

Console.WriteLine("Please enter your fourth number:");
string fourthNumber = Console.ReadLine();
int numberFour = Convert.ToInt32(fourthNumber);

Console.WriteLine("The calculated average is:");
double averageNumber = ((numberOne + numberTwo + numberThree + numberFour) / 4);
Console.WriteLine(averageNumber);
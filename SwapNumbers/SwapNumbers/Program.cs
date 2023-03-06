Console.WriteLine("Input the First Number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input the Second Number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Before Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);

int temporaryHolder = firstNumber;
firstNumber = secondNumber;
secondNumber = temporaryHolder;

Console.WriteLine("After Swapping:");
Console.WriteLine("First Number: " + firstNumber);
Console.WriteLine("Second Number: " + secondNumber);


        
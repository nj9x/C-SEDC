Console.WriteLine("Student Group");
string[] studentsG1 = new string[] { "Nenad", "Marko", "Sanja", "Maja", "Petar" };
string[] studentsG2 = new string[] { "Kristina", "Ana", "Vasko", "Nikola", "Aleksandar" };

Console.WriteLine("Enter an appropriate group number, either 1 or 2");
string input = Console.ReadLine();

int groupNumber;

if (!int.TryParse(input, out groupNumber) || (groupNumber != 1 && groupNumber != 2))
{
    Console.WriteLine("Invalid Input, enter 1 or 2");
    return;
}

Console.WriteLine($"The selected students in {groupNumber} are: ");
if (groupNumber == 1)
{
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (groupNumber == 2)
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
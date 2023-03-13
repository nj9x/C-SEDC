
using System;

Console.WriteLine("SumOfEven Application");

int[] intArray = new int[] { 2, 4, 5, 7, 8, 10, 12, 33, 43, 120 };
int sum  = 0;

for (int i = 0; i < intArray.Length; i++)
{
    if (intArray[i] % 2 == 0)
    {
        sum += intArray[i];
    }
}
Console.WriteLine(sum);
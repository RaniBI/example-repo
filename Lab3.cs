using System;
class Program
{
static void Main()
{
int[] numbers = new int[10];
for (int i = 0; i < 10; i++)
{
numbers[i] = ReadNumber(1, 100);
}
Console.WriteLine("Numbers entered:");
foreach (int number in numbers)
{
Console.WriteLine(number);
}
}
static int ReadNumber(int start, int end)
{
Console.Write("Enter a number between {0} and {1}: ", start, end);
string input = Console.ReadLine();
if (!int.TryParse(input, out int number))
{
throw new Exception("Invalid input. Please enter a valid number.");
}
if (number < start || number > end)
{
throw new Exception("Number is not within the specified range.");
}
return number;
}
}
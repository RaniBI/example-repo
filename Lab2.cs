using System;
using System.Collections.Generic;
delegate string StrDel(string str);
class TestDelegate
{
// Define the multicast delegate
private StrDel strMyDel;
// Constructor
public TestDelegate()
{
strMyDel = new StrDel(ChangeCase);
strMyDel += Reverse;
}
// Method to change case of input characters
private string ChangeCase(string str)
{
char[] arr = str.ToCharArray();
for (int i = 0; i < arr.Length; i++)
{
if (Char.IsLower(arr[i]))
arr[i] = Char.ToUpper(arr[i]);
else
arr[i] = Char.ToLower(arr[i]);
}
return new string(arr);
}
// Method to reverse the given string
private string Reverse(string str)
{
char[] arr = str.ToCharArray();
Array.Reverse(arr);
return new string(arr);
}
// Method to invoke the delegate
public string InvokeDelegate(string str)
{
return strMyDel(str);
}
}
class Program
{
static void Main(string[] args)
{
TestDelegate obj = new TestDelegate();

string input = "Hello World!";
Console.WriteLine("Original String: " + input);
Console.WriteLine("Changed Case: " + obj.InvokeDelegate(input));
Console.ReadKey();
}
}
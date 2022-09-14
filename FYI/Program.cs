// See https://aka.ms/new-console-template for more information
//FYI
//Input
//The single line of input contains a single integer N , which is a telephone number.

//Output
//Output a single integer, which is 1 if the number should be routed to the directory information operator (555 prefix), or 0 if the number should not be 
//routed to the directory information operator.
/*
string num = Console.ReadLine();
string prefix = "555";
string temp = num.Substring(0,3);
if (temp == prefix)
    Console.WriteLine("1");
else 
    Console.WriteLine("0");
*/
//string input = Console.ReadLine();
//int index1 = input.IndexOf('(');
//int index2 = input.IndexOf(')');
//Console.WriteLine(input.Substring(0, index1));
//Console.WriteLine(input.Substring(index1 + 2));
//if (input.Substring(0, index1 - 1) == input.Substring(index2 + 2))
//    Console.WriteLine("correct");
//else
//    Console.WriteLine("fix");

string input = Console.ReadLine();
int index = input.IndexOf(' ');
int a = Int32.Parse(input.Substring(0, index));
int b = Int32.Parse(input.Substring(index + 1));
if (a > b)
    Console.WriteLine("1");
else
{
    if (a == b || a < b)
        Console.WriteLine("0");
}
// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks;

//Input
//The first line of input contains the integer n (0<=n<=10), the number of the addends from the task. Each of the following n lines contains the integer 
// Pi( 10<=Pi<=9999,i=1,...,n ) from the task.

//Output
//The first and only line of output must contain the value of  x(x<=1000000000) from the original task.

int number = Int32.Parse(Console.ReadLine());
string[] input = new string[number];
long output = 0;
for (int i = 0; i < number; i++)
{
    input[i] = Console.ReadLine();
}
for (int j=0;j<input.Length;j++)
{
    //Console.WriteLine(getNumber(input[j]));
    //Console.WriteLine(getLast(input[j]));
    output += result(input[j]);
}
Console.WriteLine(output);
int getNumber(string num)
{
    return Int32.Parse(num.Remove(num.Length - 1));
}
int getLast(string num)
{
    string last = num.Substring(num.Length-1);
    return Int32.Parse(last);
}
long result (string num)
{
    int n1 = getNumber(num);
    int n2 = getLast(num);
    long result = 1;
    for (int i=0;i<n2; i++)
        result *= n1;
    return result;
}
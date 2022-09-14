// See https://aka.ms/new-console-template for more information

//Jumbo Javelin
//Input
//The first line consist of an integer N , the number of steel rods she has. Then follows N  lines, each containing a single integer li representing the length of the steel rod in cm.

//Output
//Print out the length of the jumbo javelin Jack has made for her.

//Limits
//1<N<=100
//1<=li<=50


int n = Int32.Parse(Console.ReadLine());
int[] li = new int[n];
int output = 0;
for (int i = 0; i < n; i++)
{
    li[i] = Int32.Parse(Console.ReadLine());
    output += li[i];
}
output = output - (n - 1);
Console.WriteLine(output);
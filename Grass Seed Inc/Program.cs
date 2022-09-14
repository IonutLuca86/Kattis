// See https://aka.ms/new-console-template for more information
//Grass Seed Inc.
//Input
//One line containing a real number C (0<C<=100), the cost of seed to sow one square metre of lawn.

//One line containing an integer L (0<L<=100), the number of lawns to sow.

//L lines, each containing two positive real numbers: wi (0<=IThreadPoolWorkItem<=100), the width of the lawn, and  li (0<=li<=100), the length of the lawn.

//All real numbers are given with at most 8 decimals after the decimal point.

//Output
//One line containing a real number: the cost to sow all of the lawns.

//All output must be accurate to an absolute or relative error of at most 10**-6.



double C = double.Parse(Console.ReadLine());
int L = Int32.Parse(Console.ReadLine());
string input;
double wi;
double li;
double output = 0;

int x=0;    
while( x<L)
{
    input = Console.ReadLine();
    int space = input.IndexOf(' ');
    li = double.Parse(input.Substring(0,space));
    wi = double.Parse(input.Substring(space+1));
    output += li * wi;
    x++;
    
}

Console.WriteLine(string.Format("{0:0.0000000}",output*C));

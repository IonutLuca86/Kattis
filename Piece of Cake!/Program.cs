// See https://aka.ms/new-console-template for more information
//Piece of Cake!
//    Input
//The input consists of a single line containing three integers n (2<=n<=10000), the length of the sides of the square cake in centimeters, h (0<h<n), 
//the distance of the horizontal cut from the top edge of the cake in centimeters, and v (0<v<n), the distance of the vertical cut from the left edge 
//of the cake in centimeters. This is illustrated in the figure above.

//Each cake is 4 centimeters thick.

//Output
//Display the volume (in cubic centimeters) of the largest of the four pieces of cake after the horizontal and vertical cuts are made.

string input = Console.ReadLine();
int n, v, h, output;
string[] temp = input.Split(' ');
n = Int32.Parse(temp[0]);
h = Int32.Parse(temp[1]);
v = Int32.Parse(temp[2]);
output = 0;
//if (n >= 2 && n <= 10000 && h > 0 && h < n && v > 0 && v < n)
//{
if ((n - h) < v && h < v)
{
    output = ((n - h) * v) * 4;
}
else if ((n - h) > v && h == v)
{
    output = ((n - h) * (n - h)) * 4;
}
else if ((n - h) > v && h > v)
{
    output = ((n - v) * h) * 4;
}
else
    output = ((n - v) * (n - v)) * 4;
//}
Console.WriteLine(output);


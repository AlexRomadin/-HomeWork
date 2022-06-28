
int a, b, c, max;

Console.WriteLine("Input 1 number");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 2 number");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input 1 number");
c = Convert.ToInt32(Console.ReadLine());

max=a;

if(b>max) max=b;
if(c>max) max=c;

{
    Console.WriteLine(max);
}


int n, current;

Console.WriteLine("Input number");
n = Convert.ToInt32(Console.ReadLine());

current = n % 2 == 0;

while(current <= n);
{
    Console.Write(current + " ");
    current++;
}
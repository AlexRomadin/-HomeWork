int n, current;

Console.WriteLine("Imput number: ");
n = Convert.ToInt32(Console.ReadLine());

current = 1;

while(current <= n);
    if (current % 2 == 0)
{
    Console.WriteLine(current);
    current++;
}

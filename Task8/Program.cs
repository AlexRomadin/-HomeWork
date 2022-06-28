int n, i;            

Console.Write("Input number: ");
n = Convert.ToInt32(Console.ReadLine());

i = 0;

while (i<=n)
{
	if (i % 2 == 0)
	{
		Console.WriteLine(i + " ");
		i++;
	}
}

int n;
int i = 1, k = 1;            

Console.WriteLine("Input number");
n = Convert.ToInt32(Console.ReadLine());

while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > n)
	{
		break;
	}
	i++;
}

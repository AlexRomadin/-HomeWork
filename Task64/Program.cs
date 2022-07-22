/*int NaturalNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int n = InputInt("Введите положительное число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели неверное число!");
}

Console.WriteLine(NaturalNumber(n, m));*/

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int n = InputNumbers("Введите n: ");
int count = 2;

PrintNumber(n, count);

Console.Write(-1);
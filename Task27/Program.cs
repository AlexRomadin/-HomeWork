int FindNumbersSum(int a)
{
int sum = 0;

while (a > 0)

    {
    int num = a % 10;
    a = a / 10;
    sum += num;
    }
    return sum;
}

Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма всех цифр в числе равна: {FindNumbersSum(i)}");
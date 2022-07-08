Console.WriteLine("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void NumSum();
{
    while (i > 0)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
}

Console.WriteLine("сумма всех цифр равна: " + NumSum());
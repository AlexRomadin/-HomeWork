Console.Write("Введите пятизначное число: ");
string number = Convert.ToString(Console.ReadLine());

void CheckingNumber(string number)
{
  if (number[0] == number[4] && number[1] == number[3])
  {
    Console.WriteLine("Ваше число палиндром?: Да");
  }
  else Console.WriteLine("Ваше число палиндром?: Нет");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine("Введите правильное число");
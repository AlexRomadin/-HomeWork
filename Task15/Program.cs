Console.Write("Введи цифру, обозначающую день недели: ");

int day = Convert.ToInt32(Console.ReadLine());

void WeekDay (int dayNumber) 
{
  if (day == 6 || day == 7) {
  Console.WriteLine("Этот день выходной? -> да");
  }
  else 
  
  if (day < 1 || day > 7) {
    Console.WriteLine("Это не день недели");
  }
  else Console.WriteLine("Этот день выходной? -> нет");
}

WeekDay(day);
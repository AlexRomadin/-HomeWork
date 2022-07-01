int number;

Console.WriteLine("Input number: ");
number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if(numberText.Length > 2)
{
    Console.WriteLine("Цифра № 3: " + numberText[2]);
}
else
{
    Console.WriteLine("Цифра № 3 отсутствует ^_^");
}

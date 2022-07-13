int[] CreateRandomArray(double size)
{
    int[] newArray = new int[size];

    for(int i = 0; i <  newArray.Length; i++)
        newArray[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array1 = CreateRandomArray(size);

ShowArray(array1);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array1.Length; i++)
{
    if (array1[i] > max)
        {
            max = array1[i];
        }
    if (array1[i] < min)
        {
            min = array1[i];
        }
}

Console.WriteLine($"всего {array1.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
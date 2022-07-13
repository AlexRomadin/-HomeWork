double[] CreateRandomArray(double size)
{
    double[] newArray = new double[size];

    for(int i = 0; i <  newArray.Length; i++)
        newArray[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;

    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array2 = CreateRandomArray(size);

ShowArray(array2);

double min = array2[0];
double max = array2[0];

for (int i = 0; i < array2.Length; i++)
{
    if (array2[i] > max)
        {
            max = array2[i];
        }
    if (array2[i] < min)
        {
            min = array2[i];
        }
}

Console.WriteLine($"всего {array2.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
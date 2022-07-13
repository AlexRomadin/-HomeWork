/*int[] CreateRandomArray(double size)
{
    int[] newArray = new int[size];

    for(int i = 0; i <  newArray.Length; i++)
        newArray[i] = new Random().Next(100, 1000) / 100;

    return newArray;
}
*/

void CreateRandomArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array2 = CreateRandomArray(array);

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
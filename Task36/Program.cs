int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i <  newArray.Length; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);

int sum = 0;

for (int i = 0; i < array1.Length; i+=2)
    sum += array1[i];

    Console.WriteLine($"всего {array1.Length} чисел, сумма элементов на нечётных позициях = {sum}");
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int array1 = CreateRandomArray(size, min, max);
ShowArray(array1);
int[] CreateRandomArray(int size)
{
    int[] newArray = new int[size];

    for(int i = 0; i <  newArray.Length; i++)
        newArray[i] = new Random().Next(100, 1000);
    
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

int[] array1 = CreateRandomArray(size);
ShowArray(array1);

int count = 0;

for (int i = 0; i < array1.Length; i++)
    if (array1[i] % 2 == 0)
    count++;

Console.WriteLine($"Всего {array1.Length} чисел, {count} из них чётные");
void FillArray(int [] array)
{
    int length = array.Length;
    int i = 0;
    while(i < length)
    {
        array[i] = new Random().Next(1, 20);
        i++;
    }
}

void PrintArray(int [] array)
{
    int count = array.Length;

    for(int i = 1; i < count; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}

int [] array = new int [20];

FillArray(array);
PrintArray(array);
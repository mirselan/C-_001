// Random array generation with arguments and displaying result:
////////////////////////////////////////////////////////////////
int[] RandomArrayGen (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int[] arr = RandomArrayGen(8, 0, 1);
ShowArray(arr);
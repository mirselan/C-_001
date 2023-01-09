/* Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */
///////////////////////////////////////////////////////////
int[] UserChoiceArrayGen (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Enter element of array with integer digits: ");
        int el = Convert.ToInt32(Console.ReadLine());
        arr[i] = el;
    }
    return arr;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

Console.Write("Enter size of array with integer digits: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = UserChoiceArrayGen(size);
ShowArray(array);
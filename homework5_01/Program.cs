/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
/////////////////////////////////////////////////////////////////////
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

int EvenQuantity (int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}

int minValue = 100;
int maxValue = 999;
Console.Write("Enter size of array with integer number: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArrayGen(size, minValue, maxValue);
int result = EvenQuantity(arr);
ShowArray(arr);
Console.WriteLine(result);
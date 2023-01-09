/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */
//////////////////////////////////////////////////////////////////////////
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

int SumOfOddPositions (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0) sum += array[i];
    return sum;
}

Console.Write("Enter size of array with integer numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of array with integer numbers: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of array with integer numbers: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomArrayGen(size, minValue, maxValue);
ShowArray(arr);
int result = SumOfOddPositions(arr);
Console.WriteLine(result);
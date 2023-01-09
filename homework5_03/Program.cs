/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
///////////////////////////////////////////////////////////////////
double[] RandomArrayGen (int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

double MaxMinDifference (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    double result = max - min;
    return result;
}

Console.Write("Enter size of array with integer numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter min value of array with integer numbers: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter max value of array with integer numbers: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] arr = RandomArrayGen(size, minValue, maxValue);
ShowArray(arr);

double result = MaxMinDifference(arr);
Console.WriteLine(result);
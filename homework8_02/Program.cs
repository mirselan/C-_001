/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
///////////////////////////////////////////////////////////////////////
int[,] Random2dArrayGenerator(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    return matrix;
}

void Show2dArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}

string LowestSumString (int[,] array)
{
    int[] sumOfString = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfString[i] += array[i, j];
        }
    int minIdx = 0;
    for (int i = 0; i < sumOfString.Length; i++)
        { 
            if (sumOfString[i] < sumOfString[minIdx])
                minIdx = i;
        }
    return $"{minIdx + 1} строка";
}

int[,] matrix = Random2dArrayGenerator(4, 4);
Show2dArray(matrix);
Console.WriteLine();
string result = LowestSumString(matrix);
Console.WriteLine(result);
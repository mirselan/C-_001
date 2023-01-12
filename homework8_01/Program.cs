/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8 */
///////////////////////////////////////////////////
int[,] Random2dArrayGenerator(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 10);
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

void DecrementRow2dArrayBubble (int[,] array2d)
{
    // BubbleSort of 2d array:
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        int size = array2d.GetLength(1);
        int temp = 0;
        if (size <= 1) return;
        bool bubble = true;
        while (bubble)
        {
            bubble = false;
            for (int j= 0; j + 1 < size; j++)
            {
                if (array2d[i, j] < array2d[i, j + 1])
                {
                    temp = array2d[i, j + 1];
                    array2d[i, j + 1] = array2d[i, j];
                    array2d[i, j] = temp;
                    bubble = true;
                } 
            }
            size--;
        }
    }
}

int[,] array = Random2dArrayGenerator(3, 4);
Show2dArray(array);
Console.WriteLine();
DecrementRow2dArrayBubble(array);
Show2dArray(array);
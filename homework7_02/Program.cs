/* Задача 50. Напишите программу, которая на вход принимает
позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */
///////////////////////////////////////////////////////////////////////////
int[,] Random2dArrayGenerator (int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 10);
    return matrix;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }    
}

string FindNumberFromMatrix (int rowNum, int columnNum, int[,] matrix)
{
    if (rowNum < matrix.GetLength(0) && columnNum < matrix.GetLength(1))
        return Convert.ToString(matrix[rowNum, columnNum]);
    else return "такого числа в массиве нет";
}

int m = 3;
int n = 4;

int[,] matrix = Random2dArrayGenerator(m, n);
Show2dArray(matrix);
string result = FindNumberFromMatrix(2, 2, matrix);
Console.WriteLine(result);
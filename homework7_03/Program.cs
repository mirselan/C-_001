/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
/////////////////////////////////////////////////////////////
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

string MeanColumnsNumber(int[,] matrix)
{
    string result = String.Empty;
    double sumOfColumnsNumbers = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
            sumOfColumnsNumbers += matrix[j, i];
        result += $"{Math.Round(sumOfColumnsNumbers / matrix.GetLength(0), 1)}; ";
        sumOfColumnsNumbers = 0;
    }
        
    return result;
}

int[,] mat = Random2dArrayGenerator(3, 4);
Show2dArray(mat);
Console.WriteLine();
string res = MeanColumnsNumber(mat);
Console.WriteLine(res);
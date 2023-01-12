/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49 */
////////////////////////////////////////////////
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

int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
{
    int row = matrix2.GetLength(0);
    int column = matrix1.GetLength(1);
    int row2 = matrix1.GetLength(0);
    int column2 = matrix2.GetLength(1);
    int[,] emptyArray = new int[row, column];
    int[,] result = new int[row2, column2];
    if (column == row)
    {
        for (int i = 0, k = 0; i < row2 && k < column2; i++, k++)
            for (int j = 0, l = 0; j < column && l < row; j++, l++)
                    result[i, j] += matrix1[i, j] * matrix2[k, l];
        return result;
    }
    else return emptyArray;
}

int[,] matrix1 = new int[,] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};
int[,] matrix2 = new int[,] {
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7}
};
int[,] res = MatrixMult(matrix1, matrix2);
Show2dArray(res);
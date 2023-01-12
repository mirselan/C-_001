/* Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7 */
////////////////////////////////////////////////////
int[,] Random2dArrayGenerator(int rows, int columns)
{
    int growNum = 1;
    int[,] matrix = new int[rows, columns];
    for (int i = 0, j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = 1, j = matrix.GetLength(1) - 1; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = matrix.GetLength(0) - 1, j = matrix.GetLength(1) - 2; j >= 0; j--)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = matrix.GetLength(0) - 2, j = 0; i >= 1; i--)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = 1, j = 1; j < matrix.GetLength(1) - 1; j++)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = 2, j = matrix.GetLength(1) - 2; i < matrix.GetLength(0) - 1; i++)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
    for (int i = 2, j = matrix.GetLength(1) - 3; j >= 1; j--)
        {
            matrix[i, j] = growNum;//new Random().Next(-10, 10);
            growNum++;
        }
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

int[,] array = Random2dArrayGenerator(4, 4);
Show2dArray(array);
/* Задача 60. Сформируйте трёхмерный массив
из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1) */
///////////////////////////////////////////////////////////////
int[,,] Random3dArrayGenerator(int dem1, int dem2, int dem3)
{
    int[,,] matrix = new int[dem1, dem2, dem3];
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = new Random().Next(10, 99);
    return matrix;
}

void Show3dArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,,] arr = new int[,,] {
    {
        {12, 69},
        {45, 88}
    },
    {
        {55, 10},
        {64, 22}
    }
};

Show3dArray(arr);
Console.WriteLine();
int[,,] arr2 = Random3dArrayGenerator(2, 2, 2);
Show3dArray(arr2);
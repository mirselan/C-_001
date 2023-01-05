/* Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
///////////////////////////////////////////////////////////
void TableOfCubes (int num)
{
    for (int i = 1; i <= num; i++) 
    {
        if (i != num) Console.Write($"{i * i * i}, ");
        else Console.Write(i * i * i);
    }
}

Console.Write("Enter integer number: ");
TableOfCubes(Convert.ToInt32(Console.ReadLine()));

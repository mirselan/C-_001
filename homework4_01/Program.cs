/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
//////////////////////////////////////////////////////////////////////////
// Console.WriteLine(Math.Pow(3, 5));
int ToPow (int a, int b)
{
    int res = a;
    for (int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

Console.Write("Enter integer number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter integer number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = ToPow(a, b);
Console.Write(result);
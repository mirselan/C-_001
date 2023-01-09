/* Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */
//////////////////////////////////////////////////////////////////
int SumOfDigits (int num)
{
    int numRest = 0;
    int res = 0;

    while (num > 0)
    {
        numRest = num % 10;
        res += numRest;
        num /= 10;
    }
    return res;
}

Console.Write("Enter integer number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigits(number));
/* Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
//////////////////////////////////////////////////////////////////////
void IsPalindrome (string num)
{
    while (num.Length != 5)
    {
        Console.Write("Incorrect input, enter 5-digit number: ");
        num = Console.ReadLine();
    }
    if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("да");
    else Console.WriteLine("нет");
}

Console.Write("Enter 5-digit number: ");
IsPalindrome(Console.ReadLine());
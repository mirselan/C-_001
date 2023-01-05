/* Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */
//////////////////////////////////////////////////////////////////////////
string DayOfWeek (int day) {
    if (day < 6) return "нет";
    else return "да";
}

Console.Write("Enter number of the day from 1 to 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day < 8) Console.WriteLine(DayOfWeek(day));
else Console.Write("There are just 7 days in week.");
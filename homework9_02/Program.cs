/* Задача 66: Задайте значения M и N. 
Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
//////////////////////////////////////////////////////////////////
string SumOfNaturalNumbers(int start, int finish)
{
    if(start >= 1)
    {
        int result = 0;
        for(int i = start; i <= finish; i++)
            result += i;
        return Convert.ToString(result);
    }
    else return "Incorrect input. Start number must be greater then 1.";
}

int m = 4, n = 8;
string res = SumOfNaturalNumbers(m, n);
Console.WriteLine(res);
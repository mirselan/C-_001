/* Задача 64: Задайте значения M и N. 
Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8"" */
////////////////////////////////////////////////////////////
string NaturalNumbers(int start, int finish)
{
    if(start >= 1)
    {
        string result = String.Empty;
        for(int i = start; i <= finish; i++)
            {
                if(i == finish) result += i;
                else result += $"{i}, ";
            }
        return result;
    }
    else return "Start number must to be greater then 1.";
}

int m = 1, n = 5;

string res = NaturalNumbers(m, n);
Console.WriteLine(res);
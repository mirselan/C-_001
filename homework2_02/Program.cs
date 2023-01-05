/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
///////////////////////////////////////////////////////////////////////////////
int MinusToPlus (int number) {
    return number * -1;
}

string ThirdDigit (int num) {
    if (num < 0) num = MinusToPlus(num);
    string numStr = num.ToString();
    if (numStr.Length >= 3) {
        return numStr[2].ToString();
    }
    else {
        return "третьей цифры нет";
    }
}

Console.Write("Enter your number: ");
Console.WriteLine(ThirdDigit(Convert.ToInt32(Console.ReadLine())));
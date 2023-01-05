/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
/////////////////////////////////////////////////////////////////////////////////////
int SecondNumber (int num) {
    int numTemp = num % 100;
    return numTemp / 10;
}

Console.Write("Enter integer 3-digits number: ");
int digit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecondNumber(digit));
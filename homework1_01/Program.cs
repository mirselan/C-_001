// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter integer number a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Enter integer number b: "); 
int b = int.Parse(Console.ReadLine());
int max = a;

if (a > max) {
    max = a;
}
else {
    max = b;
}

Console.Write("max = ");
Console.WriteLine(max);
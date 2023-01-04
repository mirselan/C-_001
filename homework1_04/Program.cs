// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter integer number: ");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count <= N) {
    if (count % 2 == 0) {
        if (N - count == 1 || N == count) {
            Console.Write(count);
        }
        else {
            Console.Write(count);
            Console.Write(",");
            Console.Write(" ");
        }
        
    }
    count++;
}
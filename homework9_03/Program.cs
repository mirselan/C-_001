/* Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.

m = 3, n = 2 -> A(m,n) = 29 */
//////////////////////////////////////////////////////////////////
int Akkerman(int n, int m)
            {
                if (n == 0) return m + 1;
                if (n != 0 && m == 0) return Akkerman(n - 1, 1);
                if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
                return Akkerman(n,m);
            }

int m = 3, n = 2;
int res = Akkerman(m, n);
Console.WriteLine(res);
/* Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */
//////////////////////////////////////////////////////
double[] UserChoiceArrayGen()
{
    double[] arr = new double[4];
    string[] arrKB = { "b1", "k1", "b2", "k2" };
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter {arrKB[i]}: ");
        double el = Convert.ToDouble(Console.ReadLine());
        arr[i] = el;
    }
    return arr;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

string FindPoint (double[] array)
{
    // y = k1 * x + b1, 
    // y = k2 * x + b2;
    //=> k1 * x = b1 - y,
    //=> y = k2 * x + b2;
    //=> x = (b1 - y) / k1,
    //=> y = k2 * ((b1 - y) / k1) + b2;
    //=> x = (b1 - y) / k1,
    //=> y = ((b2 / k2) * (k1 * k2) + (k2 * b1)) / (k1 + k2); 
    double b1 = array[0], b2 = array[2],
           k1 = array[1], k2 = array[3];
    double y = ((b2 / k2) * (k1 * k2) + (k2 * b1)) / (k1 + k2);
    double x = (b1 - y) / k1;
    return $"({x}; {y})";
}

double[] koefs = UserChoiceArrayGen();
ShowArray(koefs);

string result = FindPoint(koefs);
Console.WriteLine(result);

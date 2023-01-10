/* Задача 43: Напишите программу, которая найдёт 
точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5) */
//////////////////////////////////////////////////////
double[] UserChoiceArrayGen ()
{
    double[] arr = new double[4];
    string[] arrKB = {"b1", "k1", "b2", "k2"};
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Enter {arrKB[i]}: ");
        double el = Convert.ToDouble(Console.ReadLine());
        arr[i] = el;
    }
    return arr;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

// string FindPoint (double[] array)
// {
//     double x;
//     double y = array[1] * x +array[0];
//     double 
// }

double[] koefs =  UserChoiceArrayGen();
ShowArray(koefs);


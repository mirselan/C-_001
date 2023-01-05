/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
   0 1 2      3 4   - indexies
A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
/////////////////////////////////////////////////////////////////////
double Distans3D (double[] arr)
{
    double res = Math.Sqrt((arr[3] - arr[0]) * (arr[3] - arr[0]) + (arr[4] - arr[1]) * (arr[4] - arr[1]) + (arr[5] - arr[2]) * (arr[5] - arr[2]));
    return Math.Round(res, 2);
}

double[] ArrayStrToDbl (string input)
{
    while (input.Contains(",") == false)
    {
        Console.WriteLine("Incorrect input.");
        Console.Write("Enter numbers with commas, for example 1,2,3,4,5,6: ");
        input = Console.ReadLine();
    }
    string[] numStr = input.Split(new char[] { ',' });
    double[] numDbl = new double[numStr.Length];
    for (int i = 0; i < numStr.Length; i++ ) numDbl[i] = Convert.ToDouble(numStr[i]);
    return numDbl;
}

Console.Write("Enter coordinates of points A and B in 3D dimention with commas: ");
string num = Console.ReadLine();

Console.WriteLine(Distans3D(ArrayStrToDbl(num)));


 




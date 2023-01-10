/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */
////////////////////////////////////////////////////////
int[] UserChoiceArrayGen (int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i + 1} element of array with integer digits: ");
        int el = Convert.ToInt32(Console.ReadLine());
        arr[i] = el;
    }
    return arr;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int GreaterThenZeroNum (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return count;
}

Console.Write("Enter how much numbers do want to input: ");
int nums = Convert.ToInt32(Console.ReadLine());
int[] userArray = UserChoiceArrayGen(nums);
ShowArray(userArray);
Console.WriteLine();
int result = GreaterThenZeroNum(userArray);
Console.WriteLine(result);

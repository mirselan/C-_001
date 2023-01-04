void FillArray (int[] collection) {
    int length = collection.Length;
    int count = 0;
    while (count < length) {
        collection[count] = new Random().Next(1, 10);
        count++;
    }
}

void PrintArray(int[] col) {
    int len = col.Length;
    int idx = 0;
    while (idx < len) {
        Console.WriteLine(col[idx]);
        idx++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

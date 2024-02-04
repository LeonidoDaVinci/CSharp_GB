// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
int [] arr = {1,2,3,4,5};

void PrintArray(int[] arr, int n)
    {
        if (n <= 0)
            return;
        else
        {
            Console.Write(arr[n - 1] + " ");
            PrintArray(arr, n - 1);
        }
    }
int len = arr.Length;
PrintArray(arr, len);

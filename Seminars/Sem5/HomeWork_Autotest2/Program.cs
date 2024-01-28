// Задача 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int [,] numbers = //new int[,]
 {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
 };

// Печать массива
void PrintArray(int[,] array)
{
    //Напишите свое решение здесь
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// Обмен первой с последней строкой
int[,] SwapFirstLastRows(int[,] array)
{
    //Напишите свое решение здесь
    int tmp = 0;
    int n = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        tmp = array[0, j];
        array[0, j] = array[n, j];
        array[n, j] = tmp;
    }
    return array;
}

// // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//        //Напишите свое решение здесь
//     }

void PrintResult(int[,] numbers)
{
    int[,] array1 = SwapFirstLastRows(numbers);
    PrintArray(array1);
    //Напишите свое решение здесь

}

PrintResult(numbers);
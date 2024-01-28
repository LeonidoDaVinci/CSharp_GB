// Задача 3. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int [,] numbers = new int[,]
{
    {1, 30, 40},
    {1, 10, 0},
    {7, 8, 2},
    {0, 0, 1}
};
/// Вычисление сумм по строкам (на выходе массив с суммами строк)
int[] SumRows(int[,] array)
{
    //Напишите свое решение здесь 
    int n = array.GetLength(0);
    int[] ArrRow = new int[n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int SumElem = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumElem = SumElem + array[i, j];
        }
        ArrRow[i] = SumElem;
    }
    return ArrRow;
}

// Получение индекса минимального элемента в одномерном массиве
int MinIndex(int[] array)
{
    //Напишите свое решение здесь 
    int MinElem = array[0];
    int MinIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (MinElem > array[i])
        {
            MinElem = array[i];
            MinIndex = i;
        }
    }
    return MinIndex;
}
void PrintResult(int[,] numbers)
{
    //Напишите свое решение здесь
    int Row = MinIndex(SumRows(numbers));
    Console.WriteLine(Row);
}

PrintResult(numbers);
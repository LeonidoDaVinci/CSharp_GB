// Задача2. Задать двумерный массив, найти сумму элементов находящихся 
//на главной диагонали с индексами (0,0) (1,1) и т.д. 

int[,] matrix =
{
    {4, 2, 3, 9},
    {4, 5, 6, 10},
    {7, 8, 9, 11}
};

void PrintMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }
  Console.WriteLine();
}

int SumOfElementsMainDiag(int[,] table)
{
    int sum = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + table[i, j];
            }

        }
    }
    return sum;
}

PrintMatrix(matrix);
int sum = SumOfElementsMainDiag(matrix);
Console.WriteLine(sum);

// Задача1. Задать двумерный массив, найти элементыу которых оба индекса четные 
//и заменить эти элементы на их квадраты.

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

int[,] ReplaceElementsBySquares(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                table[i, j] *= table[i, j];
            }

        }
    }
    return table;
}

PrintMatrix(matrix);
ReplaceElementsBySquares(matrix);
PrintMatrix(matrix);

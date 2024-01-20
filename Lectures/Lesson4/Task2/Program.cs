// Задача 2. Создать двумерный массив, состоящий из целых чисел, вывсти на экран
// все элементы массива, если сумма их цифр четная. 

int[,] CreateMatrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1000);
        }
    }
    return matrix;
}
int[,] matrix = CreateMatrix(3, 4);

void ShowMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
}

ShowMatrix(matrix);

foreach (int e in matrix)
{
    if (isInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool isInteresting(int value)
{
    int sumOfDigits = GetSumOfDidgts(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
         return false;
}

int GetSumOfDidgts (int value)
{
    int sum = 0; 
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10; 
    }
    return sum;
}




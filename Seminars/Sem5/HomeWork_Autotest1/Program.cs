// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет: "Позиция по рядам выходит за пределы массива" или
// "Позиция по колонкам выходит за пределы массива"
// Позиции в массиве считать от единицы.

int [,] matrix = //new int[,]
    {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    };
int x = 3;
int y = 6;



// Поиск элемента по позициям
int FindElementByPosition(int[,] array, int x, int y)
{
    //Напишите свое решение здесь
    int Elem = array[x - 1, y - 1];
    return Elem;
}

// Проверка позиций на вхождение в массив
bool ValidatePosition(int[,] array, int x, int y)
{
    //Напишите свое решение здесь
    int Row = array.GetLength(0);
    int Colum = array.GetLength(1);
    if (Row >= x && Colum >= y)
    {
        return true;
    }
    else {
        return false;
    }

}

void PrintResult(int[,] numbers, int x, int y)
{
    //Напишите свое решение здесь
    if (ValidatePosition(numbers, x, y))
    {
        Console.WriteLine(FindElementByPosition(numbers, x, y));
    }
    else
    {
        Console.Write("Позиция выходит за пределы массива");
    }
}

PrintResult(matrix, x, y);

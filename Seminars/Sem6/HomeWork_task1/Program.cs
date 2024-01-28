// Задача 1: Задайте двумерный массив символов (тип char[,]). Создать строку из символов этого массива. 
char[,] charArray = {
    {'a','b','c','w'},
    {'d','e','f','q'}
    };
// Функция создания строки из двумерного массива (проход по строкам)
string GetStringFromArray(char[,] ChArr)
{
    string s1 = "";
    for (int i = 0; i < ChArr.GetLength(0); i++)
    {
        for (int j = 0; j < ChArr.GetLength(1); j++)
        {
            s1 = s1 + ChArr[i, j];
        }
    }
    return s1;
}

string result = GetStringFromArray(charArray);
Console.WriteLine(result);

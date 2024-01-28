//Задать строку с консоли в нижнем регистре и вывести количество гласных букв 
int GetVovelsCount(string str)
{
    string vovels = "aoyuei"; //строка из гласных букв
    int counter = 0;

    foreach (char c in str)
    {
        // if (vovels.Contains(c))
        // {
        //     counter++;
        // }
        foreach (char vovel in vovels)
        {
            if (c == vovel)
            {
                counter++;
            }
        }
    }
    return counter;
}
string str = Console.ReadLine()!;
int countVovels = GetVovelsCount(str);
Console.WriteLine(countVovels);

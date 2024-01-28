// Cоздать строку и перевести ее в массив символов char[]
char[] StringToArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

string str = "Hello world";
char[] chars = StringToArray(str);
// foreach (char c in chars)
// {
Console.Write(chars);
// }

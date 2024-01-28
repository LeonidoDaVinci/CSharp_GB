// СоздатьЗадать массив из символов char []  и перевести его в строку string

string GetStringFromCharArray(char[] array)
{
    string str = ""; //StringBuilber 
    foreach (char c in array)
    {
        str += c;
    }
    return str;
}
char[] chars = { '1', 'd', '!', '2', 'f' };
string str = GetStringFromCharArray(chars);
Console.Writeline(str);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные
// “aBcD1ef!-” => “abcd1ef!-” 

string text = "abCDe4g6HB";

string GetUpToLowChar(string str)
{
    string result = "";
    foreach (char e in str.ToLower()) //перебиираем каждый символ в строке и делаем все строчными
    {
        result = result + e;  //записываем новую стоку из строчных символов
    }
    return result;
}

Console.WriteLine(GetUpToLowChar(text));

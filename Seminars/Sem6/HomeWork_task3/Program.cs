// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

string text = Console.ReadLine()!;
string revers = "";
for (int i = text.Length - 1; i >= 0; i--)
{
    revers += text[i]; //записываем строку в реверсе начиная с последнего элемента
}

if (revers == text)
{
    Console.WriteLine($"Текст {text} является палиндромом");
}
else
{
    Console.WriteLine($"Текст {text} НЕ палиндром");
}

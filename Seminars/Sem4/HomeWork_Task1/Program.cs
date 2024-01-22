// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

while (true)
{
    Console.Write("Введите число или q для выхода: ");
    string input = Console.ReadLine()!;
    if (input == "q")
    {
        break;
    }
    int number = Convert.ToInt32(input);
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    if (sum % 2 == 0)
    {
        break;
    }
}
﻿//Задача 3 (Наибольшая цифра из двухзначного числа)
int a = 39;
int b = a / 10;
int c = a % 10;
if (b > c)
{
    Console.WriteLine($"Наибольшая цифра числа '{a}'  это '{b}'");
}
else
{
    Console.WriteLine($"Наибольшая цифра числа '{a}'  это '{c}'");
}
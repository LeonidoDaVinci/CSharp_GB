﻿// Задача 1  (проверка натурального числа на кратность 7 и 23)
int a = 322;
int b = a % 7; //отстаток от деления на 7
int c = a % 23;  //отстаток от деления на 23
if (b == 0 && c == 0)
{
    Console.WriteLine($"Число '{a}' КРАТНО 7 и 23");
}
else
{
    Console.WriteLine($"Число  '{a}' НЕ КРАТНО 7 и 23");
}
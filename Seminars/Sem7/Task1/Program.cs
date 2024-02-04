// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void PrintNumber(int m, int n)
{
  if (n < m) return;
  PrintNumber(m, n - 1);
  Console.Write(n + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int m = InputNumbers("Введите M: ");
int n = InputNumbers("Введите N: ");
PrintNumber(m, n);

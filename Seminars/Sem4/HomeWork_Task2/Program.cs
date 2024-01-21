// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Задайте размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Random rnd = new Random();
int count = 0;  //счетчик четных элементов
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100, 1000);  //создаем массив из трехзначных чисел
    Console.Write($"{array[i]} ");  //вывод каждого элемента массива 
    if (array[i] % 2 == 0)   // проверяем элемент на четность 
    {
        count++;
    }
}
Console.WriteLine($"Количество четных элементов масива:  {count}");
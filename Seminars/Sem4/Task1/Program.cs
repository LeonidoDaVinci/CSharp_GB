// Задание1   Создать одномерный массив, определить количество натуральных чисел
Console.WriteLine("size:");
int n = Int32.Parse(Console.ReadLine());
//1) создание массива из случайных чисел
CreateArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for( int i = 0; i< size; i++)
    {
        arr[i] = rnd.Next(0, 100);

    }
    return arr;
}

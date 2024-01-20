int[] array = new int[] { 1, 5, 34, 76, 43 };
int target = 14;
bool flag = false;
foreach (int elem in array)
{
    if (elem == target)
    {
        flag = true;
    }
if (flag == true)
    {
        Console.Write("yes");
    }
    else
    {
        Console.Write("No");
    }
}
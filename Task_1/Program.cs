// Задайте двумерный массив. Напишите 
// программу, которая будет находить 
// строку с наименьшей суммой элементов.

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n, m];
int[] arr = new int[n];

Random rand = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = rand.Next(10);
        arr[i] += array[i, j];
        Console.Write("{0} ", array[i, j]);
    }
    Console.Write("     " + arr[i]);
    Console.WriteLine();
}

int min = arr[0];
int k = 1;

for (int i = 0; i < n; i++)
{
    if(arr[i] < min)
    {
        min = arr[i];
        k = i + 1;
    }
}

Console.Write(k + " строка");
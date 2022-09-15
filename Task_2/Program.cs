// Задайте две квадратные матрицы одного размера. 
// Напишите программу, которая будет находить 
// произведение двух матриц.

Console.Write("Введите размер квадратной матрицы: ");
int N = Convert.ToInt32(Console.ReadLine());

int[,] arrayA = new int[N, N];
int[,] arrayB = new int[N, N];
int[,] arrayC = new int[N, N];

Random rand = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        arrayA[i, j] = rand.Next(0, 5);
        arrayB[i, j] = rand.Next(5, 9);
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        for (int k = 0; k < N; k++)
        {
            arrayC[i, j] += arrayA[i, k]*arrayB[k, j];
        }
    }
}
Console.WriteLine("\nПервая матрица:");
Print(arrayA);
Console.WriteLine("\nВторая матрица:");
Print(arrayB);
Console.WriteLine("\nПроизведение:");
Print(arrayC);          
 
void Print(int[,] arr)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
}

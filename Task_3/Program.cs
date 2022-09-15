// Сформируйте двухмерный массив из неповторяющихся 
// двузначных чисел (размер массива не более 50 элементов). 
// Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции: Проверить число на присутствие 
// в массиве (bool Contains(int[,] arr, int value){...} )

Console.Write("Введите количество строк в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

 if(n * m > 50)
     Console.Write("Размер массива не должен превышать 50 элементов");

else
{
    int[,] array = new int[n, m];

    Random rand = new Random();

    bool flag = true;
        
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = rand.Next(10, 100);
        }
    }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(flag == Contains(array, array[i, j]))
                {
                    array[i, j] = rand.Next(10, 100);
                    j--;
                }
                
            }
        }

        bool Contains(int[,] arr, int value)
        {
            int N = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(value == arr[i, j])
                    {
                        N++;
                        if(N == 2)
                            return true;                            
                    }
                }
            }
            
            return false;
        }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write("{0} ", array[i, j]);
        }
        Console.WriteLine();
    }
}


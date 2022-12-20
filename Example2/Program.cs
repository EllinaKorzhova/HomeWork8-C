// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] InitArray(int i, int j)
{
    int[,] array = new int[i, j];
    Random rnd = new Random();
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rnd.Next(0, 10);

        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array = InitArray(4, 4);
PrintArray(array);
Console.WriteLine();


void SearchSum(int[,] array)
{
    int[] sum = new int[array.GetLength(0)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum[j] += array[j, i];
        }
        Console.WriteLine($"Сумма {j + 1} строки: {sum[j]}");

    }
    int min = sum[0];
    int result = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        if (sum[j] < min)
        {
            min = sum[j];
            result = j;
        }
    }
    Console.WriteLine($"Минимальная строка {result + 1} c суммой {min}");
}

SearchSum(array);


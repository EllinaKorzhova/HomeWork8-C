// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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
        Console.WriteLine("   ");
    }
}


int[,] array1 = InitArray(2, 2);
int[,] array2 = InitArray(2, 2);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);



void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int[,] resultMatrix = InitArray(2, 2);

MultiplyMatrix(array1, array2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(resultMatrix);

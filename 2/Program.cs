// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);

        }

    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}

int[] FindMin(int[,] matrix)
{
    int[] numbers = new int[] { 0, 0 };
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                numbers[0] = i;
                numbers[1] = j;
            }
        }
    }
    return numbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}.");
    }
}


int[,] DeleteRawColumn(int[,] matrix, int[] array)
{
    int[,] matrix2 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1)]; // удаляем строку из исходного массива
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (i < array[0]) matrix2[i, j] = matrix[i, j];
            else matrix2[i, j] = matrix[i + 1, j];
        }
    }
    int[,] resultMatrix = new int[matrix2.GetLength(0), matrix2.GetLength(1) - 1]; // удаляем столбец из массива с удаленной строкой
    {
        for (int i = 0; i < resultMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatrix.GetLength(1); j++)
            {
                if (j < array[1]) resultMatrix[i, j] = matrix2[i, j];
                else resultMatrix[i, j] = matrix2[i, j + 1];
            }
        }
    }
    return resultMatrix;
}



int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);

int[] min = FindMin(array2D);
PrintArray(min);
Console.WriteLine();

int[,] deleteRawColumn = DeleteRawColumn(array2D, min);
PrintMatrix(deleteRawColumn);
// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            else
            {
                Console.Write($"{string.Empty,4}");
            }
        }
        Console.WriteLine(" ");
    }
}


int m;
Console.Write("Введите количество строк ");
m = int.Parse(Console.ReadLine());

int[,] trianglePaskal = new int[m, m * 2 + 1];
int x = trianglePaskal.GetLength(1) / 2;
for (int i = 0; i < trianglePaskal.GetLength(1); i++)
{
    if (i == x)
    {
        trianglePaskal[0, i] = 1;
    }
    else
    {
        trianglePaskal[0, i] = 0;
    }
}

for (int i = 1; i < trianglePaskal.GetLength(0); i++)
{
    for (int j = 1; j < trianglePaskal.GetLength(1) - 1; j++)
    {
            trianglePaskal[i, j] = trianglePaskal[i - 1, j - 1] + trianglePaskal[i - 1, j + 1];
    }
}

PrintMatrix(trianglePaskal);
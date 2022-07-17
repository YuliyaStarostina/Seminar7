// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
double[,] myArr = new double[3, 4]; 
Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        myArr[i, j] = random.NextDouble()*100;
        System.Console.Write("{0, 6:F2}", myArr[i, j]);
    }
    System.Console.WriteLine();
}

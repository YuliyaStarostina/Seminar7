// Задайте двумерный массив размером M x N, заполненный случайными целыми числами.
// M=3, N=4
int[,] myArr = new int [3, 4];
Random ran = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        myArr[i, j] = ran.Next(1, 100);
        System.Console.Write("{0}\t", myArr[i, j]);
    }
    System.Console.WriteLine();
}


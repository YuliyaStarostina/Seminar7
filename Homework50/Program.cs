
        // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
        //значение этого элемента или же указание, что такого элемента нет.
        // Например, задан массив:
        // 1 4 7 2
        // 5 9 2 3
        // 8 4 2 4
        // 17 -> такого числа в массиве нет
 int[,] mtrx = new int[3, 5];
 var ran = new Random();
{
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                     mtrx[i, j] = ran.Next(0, 10);
                     System.Console.Write($"{mtrx[i, j], 2}");   
                }
                System.Console.WriteLine();
        }
    
}

Console.Write("Введите номер строки элемента: ");
int rows = (int.Parse(Console.ReadLine()!)) - 1;
Console.Write("Введите номер столбца элемента: ");
int columns = (int.Parse(Console.ReadLine()!)) - 1;
ResultMtrx(mtrx, rows, columns);

void ResultMtrx(int[,] mtrx, int line, int clmns)
{

    if (line <= mtrx.GetLength(0) && clmns <= mtrx.GetLength(1))
    {
      Console.WriteLine($"Значение элемента на позиции равна {mtrx[line, clmns]}");
    }
    else
    {
      Console.WriteLine("Error! Такого элемента нет");
    }
}
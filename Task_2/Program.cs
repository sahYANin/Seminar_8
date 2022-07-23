/*
    Задача 58:
    Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
*/

int[,] MatrI(int n, int m)
{
    int[,] MatrixI = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            MatrixI[i, j] = new Random().Next(0, 21);
            Console.Write(MatrixI[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return MatrixI;
}

int[,] MatrANDSumm(int n, int m, int[,] MatrixI)
{
    int[,] MatrixII = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            MatrixII[i, j] = new Random().Next(0, 21);
            Console.Write(MatrixII[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            MatrixII[i, j] = MatrixII[i, j] * MatrixI[i, j];
            Console.Write(MatrixII[i, j] + "\t");
        }
        Console.WriteLine();
    }


    return MatrixII;
}

Console.Write("Введите количество строк матрицы: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int m=Convert.ToInt32(Console.ReadLine());

MatrANDSumm(n,m,MatrI(n,m));

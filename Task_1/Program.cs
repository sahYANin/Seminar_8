/*
    Задача 54: 
    Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
*/

Console.Write("Введите количество строк матрицы: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int m=Convert.ToInt32(Console.ReadLine());

int[,] Matr = new int[n, m];


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Matr[i, j] = new Random().Next(0, 101);
        Console.Write(Matr[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
    int[] num= new int[m];
    for (int j = 0; j < m; j++)
        num[j]=Matr[i,j];
    Array.Sort(num);
    for (int j = 0; j < m; j++)
        Console.Write(num[j] + " \t");
    Console.WriteLine();
}




/*

// int[,] Matr = new int[n, m];
// int[] OTV = new int[m+1];

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         Matr[i, j] = new Random().Next(0, 101);
//         Console.Write(Matr[i, j] + " \t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//         OTV[j] = Matr[i, j];
//     for (int j = 0; j < m; j++){
//         int t;
//         if(OTV[j]>OTV[j+1]) {
//             t = OTV[j];
//             OTV[j]=OTV[j+1];
//             OTV[j+1]=t;

//         }
//     Console.Write(OTV[j]+" ");
//     }
// Console.WriteLine();

// }

-----------------------------------------------------------

static void Swap(ref int e1, ref int e2)
{
    var temp = e1;
    e1 = e2;
    e2 = temp;
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());


int[,] Matr = new int[n, m];
// int[] OTV = new int[m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Matr[i, j] = new Random().Next(0, 101);
        Console.Write(Matr[i, j] + " \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
// int temp;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (var l = 1; l < j; l++)
        {
            for (var p = 0; p < p + l; j++)
            {
                if (Matr[i, l] > Matr[i, p])
                {
                    Swap(ref Matr[i, l], ref Matr[i, l+1]);
                }
            }
        }

        Console.Write(Matr[i, j] + " \t");
    }
    Console.WriteLine();
}

--------------------------------------------------------


// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         for (int l = 0; l < m - 1; l++)
//         {
//             for (int u = l + 1; u < m; u++)
//             {
//                 if (Matr[i, l] > Matr[i, u])
//                 {
//                     temp = Matr[i, l];
//                     Matr[i, l] = Matr[i, u];
//                     Matr[i, u] = temp;
//                 }
//             }
//         }
//         Console.Write(Matr[i, j] + " \t");
//     }
//     Console.WriteLine();
// }
-------------------------------------------------

// Console.WriteLine();
// int temp;

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         if (Matr[i, j] > Matr[i, j + 1])
//         {
//             temp = Matr[i, j];
//             Matr[i, j] = Matr[i, j + 1];
//             Matr[i, j + 1] = temp;
//         }


//         Console.Write(Matr[i, j] + " \t");
//     }
//     Console.WriteLine();
// }
----------------------------------------------------


// for (int l = 0; l < m - 1; l++)
//         {
//             for (int u = l + 1; u < m; u++)
//             {
//                 if (Matr[i, l] > Matr[i, u])
//                 {
//                     temp = Matr[i, l];
//                     Matr[i, l] = Matr[i, l + 1];
//                     Matr[i, l + 1] = temp;
//                 }
//             }
//         }
----------------------------

// int temp;
// Console.WriteLine();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         OTV[j] = Matr[i, j];
//         if (OTV[j] < OTV[j - 1]&& j!=0)
//         {
//             temp = OTV[j];
//             OTV[j] = OTV[j - 1];
//             OTV[j - 1] = temp;
//         }


//         Console.Write(OTV[m] + " \t");
//     }
//     Console.WriteLine();
// }



*/
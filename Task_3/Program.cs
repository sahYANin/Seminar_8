/*
    Задача 60(доп). 
    Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого 
элемента.
*/
Console.Write("Введите строк матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбцов матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите высоту матрицы: ");
int h = Convert.ToInt32(Console.ReadLine());

int[,,] Mat = new int[n, m, h];
int[] X = new int[n * m * h];
Random rnd = new Random();
int num, S = 0;
for (int i = 0; i < n * m * h;)
{
    num = rnd.Next(10, 100);
    int j;
    for (j = 0; j < i; j++)
    {
        if (num == X[j])
            break; 
    }
    if (j == i)
    { 
        X[i] = num; 
        i++; 
    }
}
// for (int i = 0; i < n*m*h; i++)
// // {
// //     Console.Write(X[i] + " ");
    
// }

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        for (int k = 0; k < h; k++)
        {
            Mat[i, j, k]=X[S];
            S++;
            Console.Write(Mat[i, j, k] + "\t" + "(" + string.Join(",", i, ",", j, ",", k) + ") ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         for (int k = 0; k < h; k++)
//         {
//             Console.Write(Mat[i, j, k] + "\t" + "( " + string.Join(",", i, ",", j, ",", k) + " )");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }








// Random rnd = new Random();
// int[] a = new int[100];
// // a[0] = rnd.Next(0, 101);
// for (int i = 0; i < 100;)
// {
//     int num = rnd.Next(0, 101); // генерируем элемент
//     int j;
//     // поиск совпадения среди заполненных элементов
//     for (j = 0; j < i; j++)
//     {
//         if (num == a[j])
//             break; // совпадение найдено, элемент не подходит
//     }
//     if (j == i)
//     { // совпадение не найдено
//         a[i] = num; // сохраняем элемент
//         i++; // переходим к следующему элементу
//     }
// }
// for (int i = 0; i < 100; i++)
// {
//     Console.Write(a[i]+"  ");
//     if (i % 10 == 9)
//         Console.WriteLine();
// }
// Console.ReadKey();


/*
// static void Shuffle(int[] arr)
// {
//     // создаем экземпляр класса Random для генерирования случайных чисел
//     Random rand = new Random();
 
//     for (int i = 8 - 1; i >= 1; i--)
//     {
//         int j = rand.Next(i + 1);
 
//         int tmp = arr[j];
//         arr[j] = arr[i];
//         arr[i] = tmp;
//     }
//     for(int i=0; i<8;i++)
//     Console.Write(arr[i]+"\t");
// }

// int[] arr = new int[8];
// Shuffle(arr);
----------------------------------------
// Random R= new Random();

// int[] N = new int[8];

// for(int i=8,j=0; i>=1;i--,j++){
//     N[j]=R.Next(i+1);
// }

// for(int i=0; i<8;i++)
//     Console.Write(N[i]+"\t");







num = rnd.Next(10,100);
            int l;
            for(l=0;l<S;l++){
                if(num==X[l])   
                    break;
            }
            if (l==i){
                Mat[i,j,k]=num;
                X[S]=num;
                S++;










*/
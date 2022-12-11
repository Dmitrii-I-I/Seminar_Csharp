// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:          // В итоге получается вот такой массив:
// 1 4 7 2                          // 7 4 2 1
// 5 9 2 3                          // 9 5 3 2
// 8 4 2 4                          // 8 4 4 2
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
 Console.Clear();
Console.WriteLine("------- Задача № 54 --------");
Console.Write("Введите кол-во сток:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("== Сортировка по убыванию элементов в строках==");
int[,] array2 = SotrRowsArray(array);
PrintArray(array2);

Console.WriteLine("------- Задача 56 --------");
Console.WriteLine($"Наименьшая сумма в строке [ {SumRowsArray(array2)} ]");



int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}");
        }
        Console.WriteLine("  ]");
    }
}

int[,] SotrRowsArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempVar = 0;
        bool flag = true;
        while (flag)
        {
            flag = false;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                {
                    tempVar = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = tempVar;
                    flag = true;
                }
            }
        }
    }
    return array;
}

int SumRowsArray(int[,] array)
{
    int minSum = 0;
    int minRows = 0;
    for (int j = 0; j < array.GetLength(1); j++) minSum +=array[0,j];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa = summa + array[i, j];
        }
        if (summa < minSum)
        {
            minSum = summa;
            minRows = i;
        }
    }
    return minRows;
}
 */

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Произведение матрицы A размера m × n и матрицы B размера n × k — это матрица C  размера m × k,
// в которой элемент с{i,j} ​равен сумме произведений элементов i-строки матрицы A на соответствующие элементы j-столбца матрицы B
// c [i,j] = a[i,1]*b[1,j] + a[i,2]*b[2,j] +...+ a[i,n]*b[n,j].
/* 
Console.Clear();
Console.WriteLine("------- Задача № 54 --------");
Console.Write("Матрица 1. Введите кол-во сток:");
int rows1 = int.Parse(Console.ReadLine()!);
Console.Write("Матрица 1. кол-во столбцов:");
int columns1 = int.Parse(Console.ReadLine()!);
Console.Write("Матрица 2. Введите кол-во сток:");
int rows2 = int.Parse(Console.ReadLine()!);
Console.Write("Матрица 2. кол-во столбцов:");
int columns2 = int.Parse(Console.ReadLine()!);
if (columns1 != rows2)
{
    Console.WriteLine($"Матрицу1 [{rows1}, {columns1}] и Матрицу2 [{rows2}, {columns2}] нельзя перемножить");
    return;
}
int[,] array1 = GetArrayRandom(rows1, columns1, 0, 10);
int[,] array2 = GetArrayRandom(rows2, columns2, 0, 10);
Console.WriteLine("===== Матрица 1 ====");
PrintArray(array1);
Console.WriteLine("===== Матрица 2 ====");
PrintArray(array2);
Console.WriteLine("=== Результат умножения ===");
int[,] arraySum = ArrayMultiplication(array1,array2);
PrintArray(arraySum);

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}");
        }
        Console.WriteLine("  ]");
    }
}

int[,] ArrayMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] arraySum = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                arraySum[i,j] +=arr1[i,k]*arr2[k,j];
            }
        }

    }
    return arraySum;
}
 */
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
Console.WriteLine("------- Задача № 60 (Массив XYZ)--------");
Console.Write("Введите кол-во сток:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите глубину (Z):");
int rowsZ = int.Parse(Console.ReadLine()!);
int[,,] array = GetArrayRandom(rows, columns, rowsZ, 0, 10);
Console.WriteLine("====================");
PrintArrayZ(array);

int[,,] GetArrayRandom(int sizeX, int sizeY, int sizeZ, int minValue, int maxValue)
{
    int[,,] array = new int[sizeX, sizeY, sizeZ];
    for (int i = 0; i < sizeX; i++)
    {
        for (int j = 0; j < sizeY; j++)
        {
            for (int k = 0; k < sizeZ; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

void PrintArrayZ(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine("]");
        }
    }
}

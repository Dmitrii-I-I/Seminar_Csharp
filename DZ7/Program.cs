// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.        0,5 7 -2 -0,2       1 -3,3 8 -9,9       // 8 7,8 -7,1 9
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 5; j = 2 -> такого числа в массиве нет
// i = 1; j = 1 -> 9
/* Console.Clear();
Console.WriteLine("------- Задача № 47 --------");
Console.Write("Введите кол-во сток:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine()!);
double[,] arrayDoub = GetArrayRandomDouble(rows, columns, -100, 100);
PrintArray(arrayDoub);
Console.WriteLine("------- Задача № 50 --------");
Console.Write("Введите координаты ячейки в формате Х,Y: ");
string coordinat = Console.ReadLine()!;
if (NumToString(coordinat))
{
    int[] coordElem = GetElement(coordinat);
    Console.WriteLine($"Ищем [ {String.Join(", ", coordElem)} ]");
    PrintElem(arrayDoub, coordElem);
}
else Console.WriteLine("Не корректно введены координаты");


double[,] GetArrayRandomDouble(int sizeM, int sizeN, int minValue, int maxValue)
{
    double[,] array = new double[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]:f1}");
        }
        Console.WriteLine("  ]");
    }
}

int[] GetElement(string coord)
{
    int[] array = new int[2];
    coord = coord.Replace(" ", "");
    if (coord=="")
    {
        array[0] = 0;
        array[1] = 0;
    }
    else
    {
        string stroka = "";
        for (int i = 0; i < coord.Length; i++)
        {
            if (coord[i] == ',')
            {
                array[0] = Convert.ToInt32(stroka);
                stroka = "";
            }
            else stroka = stroka + coord[i];
        }
        array[1] = Convert.ToInt32(stroka);
    }
    return array;
}

void PrintElem(double[,] Array, int[] ArrayElem)
{
    if (ArrayElem[0] < Array.GetLength(0) && ArrayElem[1] < Array.GetLength(1))
    {
        Console.WriteLine($"Элемент [ {ArrayElem[0]}, {ArrayElem[1]} ] = {Array[ArrayElem[0], ArrayElem[1]]:f1}");
    }
    else Console.WriteLine($"Элемента [ {ArrayElem[0]}, {ArrayElem[1]} ] нет.");
}

bool NumToString(string stroka)
{
    bool flag = true;
    string provString = " +-,0123456789";
    for (int i = 0; i < stroka.Length; i++)
    {
        if (provString.Contains(stroka[i]) == false) flag = false;
    }
    return flag;
} */

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("------- Задача № 52 --------");
Console.Write("Введите кол-во сток:");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов:");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArrayRandom(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Среднее арифм. по столбцам");
GetAvgColumn(array);

int[,] GetArrayRandom(int sizeM, int sizeN, int minValue, int maxValue)
{
    int[,] array = new int[sizeM, sizeN];
    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            // array[i, j]=i+j;
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

void GetAvgColumn(int[,] array)
{
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i, j];
            }
            Console.Write($"  {(sum / array.GetLength(0)):f2}  ");
        }
    }
    Console.WriteLine("]");
}
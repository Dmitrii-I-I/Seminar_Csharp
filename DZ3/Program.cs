////////////// Задача 19 //////////////// принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему).
// 14212 -> нет      12821 -> да      23432 -> да
/* Console.WriteLine("Введите любое целое число :");
int number = int.Parse(Console.ReadLine()!);
int razr = (int)Math.Log10(number);
string numberS = Convert.ToString(number);
if (razr != 4) Console.WriteLine("Не пятизначное число");
int flag = 0;
for (int i=0; i<(razr+1)/2; i++) {
    if(numberS[i] != numberS[(razr-i)]) {flag=flag+1;}
}
if (flag==0) {Console.WriteLine("Число полиндром");}
else {Console.WriteLine("Число НЕ полиндром");} */


////////////// Задача 21 //////////////// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84            A (7,-5, 0); B (1,-1,9) -> 11.53
/* int[,] mas = new int [2,3] {{3, 6, 8},{2, 1, -7}};
// int[,] mas = new int [2,3] {{7, -5, 0},{1, -1, 9}};
double masR = Math.Sqrt(Math.Pow(mas[0,0]-mas[1,0], 2) + Math.Pow(mas[0,1]-mas[1,1], 2) + Math.Pow(mas[0,2]-mas[1,2], 2));
Console.WriteLine($"Расстояние между точками {masR:f2}");
 */
 
////////////// Задача 23  ////////////// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27            5 -> 1, 8, 27, 64, 125
/* Console.Write("Введи целое число: ");
int num = int.Parse(Console.ReadLine()!);
if (num < 0)
{
    Console.WriteLine("Число отрицательно преобразовано в положительное");
    num = -num;
}
Console.Write($"Таблица кубов чисел до {num} --> ");
for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}  ");
    } */
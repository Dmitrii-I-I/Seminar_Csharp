// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/* 
Console.Clear();
Console.Write("Введите натуральное число N: ");
int N=int.Parse(Console.ReadLine()!);

if (N<=0){
    Console.WriteLine ("Не натуральное число :(");
    return;
}

Console.WriteLine(PrintNumbers(1,N));

string PrintNumbers(int start, int end){
    if (end==start) return start.ToString();
    return (end + " " +  PrintNumbers(start, end-1));
}
 */
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/* 
Console.Clear();
Console.Write("Введите натуральное число N: ");
int N=int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число S: ");
int S=int.Parse(Console.ReadLine()!);

if (S>N) {
    Console.WriteLine ("Не корректный ввод");
    return;
}
Console.WriteLine($"Сумма чисел от {S} до {N} = {PrintNumbers(S,N)}");


int PrintNumbers(int start, int end){
    if (start==end) return start;
    return (start + PrintNumbers(start+1, end));
}
 */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Введите натуральное число М: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число N: ");
int N = int.Parse(Console.ReadLine()!);

if (M < 0 || N < 0)
{
    Console.WriteLine("Не корректный ввод");
    return;
}
Console.WriteLine($"Функция Аккермана А({M},{N}) = {FunctionAccerman(M, N)}");


int FunctionAccerman(int M, int N)
{
    if (M==0) return (N+1);
    if (N==0) return FunctionAccerman(M-1,1);
    return FunctionAccerman(M-1, FunctionAccerman(M, N-1));
    // Альтернативная запись
    // return (M == 0) ? (N + 1) : (N == 0) ? FunctionAccerman(M - 1, 1) : FunctionAccerman(M - 1, FunctionAccerman(M, N - 1));
}

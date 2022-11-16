//////// Задача 2  ///////////// на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);
if(number1>number2){
    Console.WriteLine($"Число1: {number1} больше числа2: {number2} ");
}
else
    if(number1<number2){
    Console.WriteLine($"Число1: {number1} меньше числа2: {number2} ");
    }
    else {Console.WriteLine($"Число1: {number1} равно числу2: {number2} ");}

//////// Задача 4  ///////////// принимает на вход три числа и выдаёт максимальное из этих чисел.
/* Console.Write("Введите нижнюю границу диапазона: ");
int gr1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите верхнюю границу диапазона: ");
int gr2 = int.Parse(Console.ReadLine()!);
if (gr2 > gr1)
{
    int[] array = new int[3];
    int i = 0;
    while (i < 3)
    {
        array[i] = new Random().Next(gr1, gr2 + 1);
        Console.WriteLine($"Число [{i + 1}] = {array[i]}");
        i++;
    }
    i = 0;
    int max = array[i];
    while (i < 3)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        i++;
    }
    Console.WriteLine($"Максимальное число: {max}");
}
else { Console.WriteLine("Не корректно задан диапазон"); } */

//////// Задача 6  ///////////// принимает на вход три числа и выдаёт максимальное из этих чисел.
/* Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
if (number % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else { Console.WriteLine("Число не четное"); } */

//////// Задача 8  ///////////// а вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/* Console.Write("Введите число: ");
int numberN = int.Parse(Console.ReadLine()!);
if (numberN > 0)
{
    int i = 1;
    while (i < numberN + 1)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i}  ");
        }
        i++;

    }
}
else { Console.WriteLine("Не корректно задан диапазон"); } */

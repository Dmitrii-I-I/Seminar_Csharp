////// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow,
////// будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
////// 3, 5 -> 243 (3⁵)         2, 4 -> 16           
/* Console.Write("Введите число А: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите число (степень) В: ");
int pow = int.Parse(Console.ReadLine()!);
Console.Write($"Число {num} в степени {pow} = {num_pow(num, pow):f4}");

double num_pow (int number, int pow){
    double multip=1;
    double number_multip=number;
    if(pow<0) {
        Console.WriteLine("Вы ввели отрицательную степень!");
        number_multip=1/(double)number;
        pow *=-1;   
    }
    if (pow!=0) for (int i=1; i<=pow; i++)  multip *=number_multip;
    else multip=1;
  return multip;
} */

////// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
////// 452 -> 11           82 -> 10        9012 -> 12
/* Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе '{num}' = {num_sum(num)}");

double num_sum (int number){
    int summa=0;
    if (number<0){
    Console.WriteLine("Число отрицательное :)");
    number *=-1;
    }
    while(number>0) {
        summa=summa + number%10;
        number = number/10;
    }
  return summa;
} */


//////  Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)
Console.Write("Введите число элементов массива (до 8): ");
int num = int.Parse(Console.ReadLine()!);
if (num>0 && num<=8){
    int[] array_write = ArrayRan(num);
    ArrayWrite(array_write);
}
else { Console.WriteLine("Число вне диапазона 1 - 8");}

//  ---- Методы ---
int[] ArrayRan(int count){
int[] array = new int[count];
    for (int i=0; i<array.Length; i++)  array[i]=new Random().Next(0,101);
    return array;
}
// м-д длинный, но хотелось заморочиться без String.Join
void ArrayWrite(int[] array){
    Console.Write($"Массив из {array.Length} элементов [ ");
for (int i=0; i<array.Length; i++){
    if (i != array.Length-1) Console.Write($"{array[i]}, ");
    else Console.Write($"{array[i]}");
    }
    Console.WriteLine(" ]");
}
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/* Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = GetArray(size, 100, 999);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Четных элементов: {FindPozitive(array)}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
int FindPozitive(int[] array){
    int count=0;
    foreach(int elem in array){
    if(elem%2 == 0)  count++;
    }
return count;
} */

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19         [-4, -6, 89, 6] -> 0
Console.Write("Введите число элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.Write("Введите нижнюю границу массива: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите вернюю границу массива: ");
int maxValue = int.Parse(Console.ReadLine()!);
if (size>0 && minValue < maxValue){
int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Сумма элнментов с нечетными индексами: {SumElem(array)}");
}
else Console.WriteLine("Не коректные входные данные");

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
int SumElem(int[] array){
   int summa=0; 
   for (int i=0; i<array.Length; i++){
    if (i%2 != 0) summa += array[i]; 
   }
    return summa;
}

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3         [6 7 3 6] -> 36 21

// Задача 38: Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

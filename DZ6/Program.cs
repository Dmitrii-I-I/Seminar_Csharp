// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2            1, -7, 567, 89, 223-> 4
Console.Write("Введите целые числа через запятую: ");
string stroka = Console.ReadLine()!;
stroka = stroka.Replace(" ", "");
if (NumToString(stroka))
{
    int[] array = GetArray(stroka);
    Console.WriteLine($"Вывод массива в строку: [ {String.Join(", ", array)} ]");
    Console.WriteLine($"Чисел больше нуля: {GetCountPositiveElementArray(array)}");
}
else Console.WriteLine("Введены не корректные данные");

int[] GetArray(string strok)
{
    int countStrok = 0; // находим кол-во чисел, длину массива
    for (int i = 0; i < strok.Length; i++)
    {
        if (strok[i] == ',') { countStrok++; }
    }
    countStrok++;
    Console.WriteLine($"Всего чисел: {countStrok}");
    int[] arrayNumber = new int[countStrok]; // массив чисел
    int j = 0;
    string numberString = "";
    for (int i = 0; i < strok.Length; i++)
    {

        if (strok[i] != ',')
        {  // не запятая
            numberString = numberString + strok[i];
        }
        else
        {
            arrayNumber[j] = Convert.ToInt32(numberString);
            j++;
            numberString = "";
        }
    }
    arrayNumber[j] = Convert.ToInt32(numberString);  // крайний элемент
    return arrayNumber;
}

int GetCountPositiveElementArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
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
}

// Задача 43: Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

/* int[] array = GetArrayRandom(10, 0, 100);
Console.WriteLine($"Вывод массива в строку: [ {String.Join(", ", array)} ]");
Console.WriteLine($"Сортировка по возрастанию: [ {String.Join(", ", SotrArray(array))} ]");

int[] SotrArray(int[] array)
{
    int tempVar=0;
    bool flag=true;
    while (flag)
    {
        flag=false;
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j + 1])
            {
                tempVar = array[j];
                array[j] = array[j + 1];
                array[j + 1] = tempVar;
                flag = true;
            }
        }
    }
    return array;
}

int[] GetArrayRandom(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
 */
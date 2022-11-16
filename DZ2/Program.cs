/////// Задание 10 ////// принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
Console.Write("Введите трехзначное число:  ");
int number = int.Parse(Console.ReadLine()!);
if (number>99 && number<1000){
    Console.WriteLine($"Вторая цифра: {(number/10)%10}");
    }
else {Console.WriteLine("Число не трехзначное");}

/////// Задание 13 (решение через преобразование типов) ////// выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
/* Console.Write("Введите число до 100 000: ");
int number = int.Parse(Console.ReadLine()!);
if (number<100000 && number>0){
    if(number>99){
        Console.WriteLine($"Третья цифра слева числа {number} - {Convert.ToString(number)[2]}");
    }
    else {Console.WriteLine("--> Третьей цифры нет");}
}
else { Console.WriteLine("--> Число вне диапазона 0-100000"); } */

/////// Задание 13 (решение через логарифм и выбор цифры слева) ////// выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
/* Console.Write("Введите число до 100 000: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Какую цифру слева вывести : ");
int numberN = int.Parse(Console.ReadLine()!);
if (number<100000 && number>0){
    if(number>(Math.Pow(10,numberN-1)-1)){
        Console.WriteLine($" {numberN}-я по счету цифры слева: {(number/(int)Math.Pow(10, (int)Math.Log10(number)-numberN+1))%10}");
    }
    else {Console.WriteLine($"--> Нет {numberN}-й по счету цифра слева");}
}
else { Console.WriteLine("--> Число вне диапазона 0-100000"); } */

// ///// Задание 15 ////// принимаем на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >8
/* Console.Write("Введите порядковый номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);
String[] array={"понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
if (number>0 && number<8){
    Console.WriteLine($"{number} день недели {array[number-1]}");
}
else {Console.WriteLine("Не корректный ввод");} */
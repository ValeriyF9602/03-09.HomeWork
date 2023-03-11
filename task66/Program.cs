/**********************************************************

Задача 66
Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

**********************************************************/


int[] ReadIntRange(string text) // Приглашение ко вводу целых чисел
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

int SumNaturalElements(int firstNum, int lastNum) // Сумма элементов в промежутке от firstNum до lastNum
{
    if (lastNum == firstNum - 1) return 0;
    return lastNum + SumNaturalElements(firstNum, lastNum - 1);
}



Console.WriteLine();
Console.WriteLine("Сумма натуральных элементов в промежутке от X до Y с шагом 1. Условие "
                + "выполнения программы: в указанный диапазон должны входить натуральные числа");
Console.WriteLine();

int[] range = ReadIntRange("Укажите диапазон из натуральных чисел через пробел: "); // Решил диапазон указывать через пробел за раз

Console.WriteLine();

if (range[0] > 0 || range[1] > 0)
{                                                                                                           // Пояснение условия
    if (range[0] < range[1])                                                                        // По условию найти сумму НАТУРАЛЬНЫХ элементов в диапазоне.
    {                                                                                               // В программе очерёдность ввода первого и последнего элементов
        Console.Write($"Сумма НАТУРАЛЬНЫХ элементов в промежутке от {range[0]} до {range[1]}: ");   // не учитывается (можно вводить в любом порядке)

        if (range[0] < 1) range[0] = 1;                                                             // Крайний элемент диапазона должен быть натуральным.
        Console.WriteLine(SumNaturalElements(range[0], range[1]));
    }                                                                                               // Если начальный элемент меньше 1 — присваиваем ему 1,
                                                                                                    // но в выводе укажем ВВЕДЁННЫЙ диапазон.
    else
    {
        Console.Write($"Сумма НАТУРАЛЬНЫХ элементов в промежутке от {range[1]} до {range[0]}: ");

        if (range[1] < 1) range[1] = 1;
        Console.WriteLine(SumNaturalElements(range[1], range[0]));
    }
}

else Console.WriteLine("Условие программы не выполнено!");
Console.WriteLine();
/*

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/


// Решил на всякий случай, хоть вы и убрали эту задачу из ДЗ

int ReadInt(string text) // Метод приглашения ко вводу целого числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNaturalNums(int number) // Метод вывода натуральных чисел от number до 1
{
    if (number == 0) return;
    Console.Write($"{number} ");
    PrintNaturalNums(number - 1);
}


Console.WriteLine();
int num = ReadInt("Введите натуральное число (N): ");
Console.WriteLine();

if (num > 0) // Введённое число должно быть от 1 и более
{
    Console.Write($"N = {num} —> ");
    PrintNaturalNums(num);
    Console.WriteLine();
}
else Console.WriteLine("Число должно быть натуральным!");

Console.WriteLine();
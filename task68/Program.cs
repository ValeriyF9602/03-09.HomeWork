/*******************************************************

Задача 68
Напишите программу вычисления функции Аккермана с
помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

*******************************************************/


int[] ReadInt(string text) // Ввод значений через пробел
{
    Console.Write(text);
    return Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
}

int Ackermann(int m, int n) // Функция Аккермана
{
    if (m == 0 && n >= 0) return n + 1; // дополнительное условие: n >= 0
    if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    if (m > 0 && n > 0) return Ackermann(m - 1, Ackermann(m, n - 1));
    return -1;
}



Console.WriteLine();
int[] numbers = ReadInt("Введите неотрицательные m и n функции Аккермана через пробел: ");

int result = Ackermann(numbers[0], numbers[1]);

Console.WriteLine();
if (result == -1) Console.WriteLine("\t" + "Указаны неверные значения m и n!");

else Console.WriteLine("\t" + $"m = {numbers[0]}, n = {numbers[1]} —> A(m,n) = {result}");
Console.WriteLine();
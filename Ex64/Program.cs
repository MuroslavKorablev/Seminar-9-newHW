﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
System.Console.WriteLine(PrintNaturalNumbers(5));

string PrintNaturalNumbers(int number)
{
    if (number == 1) return "1 ";
    else return $"{number} " + PrintNaturalNumbers(number - 1); // От N до 1
}
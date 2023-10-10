// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = 1; int N = 15;
int sum = FindSumOfNaturalNumbers(M, N);
System.Console.WriteLine($"M = {M}, а N = {N} -> {sum}");
int FindSumOfNaturalNumbers(int M ,int N)
{
    if (M > N) return 0;
    else return M + FindSumOfNaturalNumbers(M + 1, N);
}
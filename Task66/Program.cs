// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("\nВведите значение числа M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа N = ");
int N = Convert.ToInt32(Console.ReadLine());
int temp = 0;
int SumNumbers(int start, int end)
{
    if (start > end) //При М>N меняем направление суммирования значений
    {
        temp = start;
        start = end;
        end = temp;
    }
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}

Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers(M, N)}");

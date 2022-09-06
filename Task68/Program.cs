// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("\nВведите значение числа M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение числа N = ");
int N = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) return (n + 1);
    if (n == 0) return (Akkerman(m - 1, 1));
    return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.WriteLine($"m = {M}; n = {N} -> A(m,n) = {Akkerman(M, N)}");

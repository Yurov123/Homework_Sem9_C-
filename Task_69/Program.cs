// Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
// M = 1; N = 4 -> 10 M = 4; N = 8. -> 30
Console.Clear();



Console.WriteLine("Enter M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = int.Parse(Console.ReadLine());
int summa = 0;
int Sum(int m, int n)
{
    if (m < n)
    {
        summa = summa + m;
        Sum(m + 1, n);
        return summa + n;
    }
    else if (m > n)
    {
        summa = summa + n;
        Sum(m, n + 1);
        return summa + m;
    }
    else
    {
        return summa;
    }
}
Console.WriteLine(Sum(m, n));
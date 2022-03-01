// Показать натуральные числа от N до 1, N задано. N = 5

Console.Clear();

int List(int n)
{
    if(n == 0) return 0;
    Console.Write(n  +" , ");
    return List(n-1);
}

Console.WriteLine("Enter interval boundary:"); // Введите границу интервала
int n = int.Parse(Console.ReadLine());
List(n);
Console.WriteLine();

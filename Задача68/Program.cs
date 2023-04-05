int f(int a, int b)
{
   if (a == 0)
        return b + 1;
    else if (b == 0 && a > 0)
        return f(a - 1, 1);
    else
        return (f(a - 1, f(a, b - 1)));
}
Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));
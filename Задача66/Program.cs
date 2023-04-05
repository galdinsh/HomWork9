int f(int a, int b)
{
  if (a == b)
    return a;
  return f(a, b - 1) + b;
}

Console.Clear();
Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма всех элементов от {m} до {n} = {f(m, n)}");
//Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] a = new int[10];
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите a[{i}] = ");
    a[i] = int.Parse(Console.ReadLine());
}
int sum = 0;
for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 1)
    sum += a[i];
}
Console.WriteLine($"Сумма нечетных чисел = {sum}");


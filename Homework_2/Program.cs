//Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетных\четных чисел
int[] a = new int[100];
 
Random random = new Random();
for (int i = 0; i < a.Length; i++)
a[i] = random.Next(100, 1000);
 
int c = a.Count(x => x % 2 == 0);
int n = a.Count(x => x % 2 != 0);
            
Console.WriteLine($"Сам массив {string.Join(", ", a)}\nЧетные {c}\nНечетные {n}");


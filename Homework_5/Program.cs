//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
 Console.WriteLine("Array Size: "); 
int n; 
n = Convert.ToInt32(Console.ReadLine()); 
int[] ar = new int[n]; 
var rand = new Random(); 
       
for(int i = 0; i < ar.Length; i++) 
ar[i] = rand.Next(-100, 100); 
Console.Write("Values of array elements: "); 
foreach(var item in ar) 
Console.Write("{0} ", item); 
Console.WriteLine(); 
for(int i = 0; i < ar.Length / 2; i++) 
Console.WriteLine("element {0} * element {1}, {2} * {3}  = {4}", i, ar.Length - i - 1, ar[i], ar[ar.Length - i - 1], ar[i] * ar[ar.Length - i - 1]); 
return; 


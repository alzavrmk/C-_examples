//Таблица кубов n чисел 
Console.WriteLine("Введите число n");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++) Console.Write($"{i * i * i} ");
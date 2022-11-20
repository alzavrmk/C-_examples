// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degre(int num, int deg)
{
    int degre = 1;
    for (int i = 1; i <= deg; i++)
    {
        degre = degre * num;
    }
    return degre;
}

Console.Write("Введите число а ");
int a = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число b ");
int b = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"{a} в степени {b} равно {Degre (a,b)}");
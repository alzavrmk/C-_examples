//Вывести вторую цифру трехзначного числа
Console.Write("Введите трехзначное целое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int b=(numberA / 10) % 10;
Console.WriteLine($"Вторая цифра числа {numberA} равна {b}");
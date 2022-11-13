// //2
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if( num1 % num2==0) Console.WriteLine("Кратно");
// else Console.WriteLine ($"  не Кратно, остаток от деления = {num1%num2}");


// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 % 7 == 0 && num1 % 23 == 0)
// {
//     Console.WriteLine($" {num1} кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine($" {num1} не кратно 7 и 23");
// }

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1==num2*num2) Console.WriteLine($" {num1} является квадратом числа {num2}");
else Console.WriteLine($" {num1} не является квадратом числа {num2}");



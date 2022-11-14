// Программа выводит третью цифру справа в любом многозначном числе если эта цифра существует.
Console.Write("Введите любое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if (numA < 100) Console.WriteLine("Третьей цифры в этом числе нет");
else
{
    while (numA > 1000)  numA = numA / 10;
    Console.WriteLine($"Третья цифра справа равна {numA % 10}");
};

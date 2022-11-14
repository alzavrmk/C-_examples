// По номеру для недели определить является ли он выходным.
Console.Write ("Введите номер дня недели (число от 1 до 7) ");
int dayWeek = Convert.ToByte(Console.ReadLine());

if (dayWeek<6) Console.WriteLine ("Нет");
else Console.WriteLine("Да, выходной");
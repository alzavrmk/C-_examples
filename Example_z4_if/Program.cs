﻿Console.Write("a= ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("b= ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("c= ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
   max = numberB;
}
else if (numberC>max)
{
  max = numberC;  
}
Console.Write($"max={max}");
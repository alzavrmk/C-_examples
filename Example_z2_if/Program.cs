// See https://aka.ms/new-console-template for more information
Console.Write("a= ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("b= ");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (numberA > numberB)
{
   max = numberA;
}
else
{
  max = numberB;  
}
Console.Write("max=");
Console.Write(max);
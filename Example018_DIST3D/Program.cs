int[] x = new int[3];
int[] y = new int[3];

for (int i = 0; i < 3; i++)
{
    // Console.Write($"x{i+1}= ");  x[i]= Convert.ToInt32(Console.Read());  
    // Console.Write($" y{i+1}= ");  y[i]= Convert.ToInt32(Console.ReadLine());  
    x[i] = new Random().Next(1, 100);
    y[i] = new Random().Next(1, 10);

}
Console.WriteLine($"A({x[0]}; {x[1]}; {x[2]})");
Console.WriteLine($"B({y[0]}; {y[1]}; {y[2]})");

double ab = Math.Sqrt(Math.Pow((x[0] - y[0]), 2) + Math.Pow((x[1] - y[1]), 2) + Math.Pow((x[2] - y[2]), 2));
Console.WriteLine($"|AB|= {Math.Round(ab)}");


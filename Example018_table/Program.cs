Console.WriteLine("Введите пятизначное число ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 10000 || n > 1000000)
{
    Console.WriteLine("Введено неверно. Введите пятизначное число. ");
    n = Convert.ToInt32(Console.ReadLine());
}

int [] dig=new int [5];

for (int i=0; i<5; i++)
{
    dig[i]=n%10;
    n=n/10;
    //Console.WriteLine(dig[i]);
    //Console.WriteLine(n);
}
if (dig[0]==dig[4] && dig[1]==dig[3]) Console.WriteLine("Да");
else Console.WriteLine("Нет");
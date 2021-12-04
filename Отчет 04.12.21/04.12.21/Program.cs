Console.WriteLine("Введите значение а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение c");
int c = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение d");
int d = int.Parse(Console.ReadLine());
int x = 0;
int y = 0;
if (a < b)
{
    x = a;
}
else
{
    x = b;
}
if (c < d)
{
    y = c;
}
else
{
    y = d;
}
if (x < y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}

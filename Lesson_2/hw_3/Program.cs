Console.WriteLine("print a number: ");
int x= int.Parse(Console.ReadLine()!);
if( x<=99 &&x>=10)
{
    int a=x/10;
    int b=x%10;
    if (a>b)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(b);
    }
}
Console.WriteLine("Число не лежит на отрезке [10, 99]");
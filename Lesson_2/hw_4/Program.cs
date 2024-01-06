Console.Write("Введите натуральное число N: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 10)
{
    Console.WriteLine(a);
}
else
{
    while (a > 0)
    {
        int b = a % 10;
        a /= 10;
        if (a > 0)
        {
            Console.Write(b + ",");
        }
        else
        {
            Console.WriteLine(b);
        }
    }
}

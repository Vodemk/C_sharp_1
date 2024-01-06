Console.WriteLine("print first number: ");
int a= int.Parse(Console.ReadLine()!);
Console.WriteLine("print second number: ");
int b= int.Parse(Console.ReadLine()!);
if (a%b==0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет, "+a%b);
} 
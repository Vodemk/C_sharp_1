Console.WriteLine("print a number: ");
int a= int.Parse(Console.ReadLine()!);
int secnum=a/10 %10;
int thirdnum=a%10;
Console.WriteLine(Math.Pow(secnum, thirdnum));
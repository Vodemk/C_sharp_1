﻿Console.WriteLine("print first number: ");
int x= int.Parse(Console.ReadLine()!);
Console.WriteLine("print second number: ");
int y= int.Parse(Console.ReadLine()!);
if (x>0 && y>0)
    Console.WriteLine("1");
else if (x<0 && y>0)
    Console.WriteLine("2");
else if (x<0 && y<0)
    Console.WriteLine("3");
else if (x>0 && y<0)
    Console.WriteLine("4");
else
    Console.WriteLine("Координата находится на оси координат");

﻿// See https://aka.ms/new-console-template for more information
double lenght = double.Parse(Console.ReadLine());
double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());

double volume = (lenght * width * height)/3 ;

Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");

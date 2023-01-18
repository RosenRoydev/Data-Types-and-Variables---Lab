// See https://aka.ms/new-console-template for more information
decimal pound = decimal.Parse(Console.ReadLine());

decimal dollars = pound * 1.31m;

Console.WriteLine($"{dollars:f3}");



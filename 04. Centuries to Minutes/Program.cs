// See https://aka.ms/new-console-template for more information
int centurys = int.Parse(Console.ReadLine());

int years = centurys * 100;
decimal days = Math.Floor(years * 365.2422m);
decimal hours = days * 24m;
decimal minutes = hours * 60;

Console.WriteLine($"{centurys} centuries = {years} years = {days:f0} days = {hours:f0} hours = {minutes:f0} minutes");

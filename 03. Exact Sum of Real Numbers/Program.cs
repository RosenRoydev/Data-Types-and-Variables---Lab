// See https://aka.ms/new-console-template for more information

decimal N = decimal.Parse(Console.ReadLine());
decimal sum=0;

for (int i = 0; i < N; i++)
{
    sum += decimal.Parse(Console.ReadLine());

}
Console.WriteLine(sum);
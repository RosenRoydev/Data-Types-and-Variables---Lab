// See https://aka.ms/new-console-template for more information
int digit = int.Parse(Console.ReadLine());
int sum = 0;
int sumAcumulate = 0;



for (int i = 1; i <= digit; i++)
{
	int digitCopy = i;
	int copyI = i;

        while (copyI > 0)
        {
            digitCopy = copyI % 10;
            copyI /= 10;
            sum += digitCopy;
            
        }
        
        if (sum  == 7 || sum  == 5 || sum  == 11)
        {
            Console.WriteLine($"{i} -> True");
        }
        else
        {
            Console.WriteLine($"{i} -> False");

        }
        sum = 0;
}

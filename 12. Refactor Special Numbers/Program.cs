int number = int.Parse(Console.ReadLine());
int obshto = 0;
int numberCopy = number;
bool specialNumber = false;
for (int i = 1; i <= number; i++)
{
    int iCopy = i;
    
    while (iCopy > 0)
    {
        obshto += iCopy % 10;
        iCopy = iCopy / 10;
        
    }
    if (obshto == 5 || obshto == 7 || obshto == 11)
    {
        specialNumber = true;
        Console.WriteLine($"{i} -> {specialNumber}");
    }
    else
    {
        specialNumber=false;
        Console.WriteLine($"{i} -> {specialNumber}");
    }

    obshto = 0;
    
}


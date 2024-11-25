/*
 * Prime Number Finder
Objective: Create a program that finds and displays all prime numbers up to a given limit.
For loop: Loop through numbers and check for divisibility to identify prime numbers.
*/

int factors = 0;

Console.Write("Write a limit\n");

int limit = int.Parse(Console.ReadLine());

for (int i = 2; i < limit; i++)
{
    factors = 0;
    for (int n = 1; n < limit; n++)
    {
       
        if (0 == i % n)
            
        {
            factors = factors + 1;
        }
        
    }
    if (factors == 2)
    {
        Console.WriteLine(i);
    }
};
Console.ReadLine();
























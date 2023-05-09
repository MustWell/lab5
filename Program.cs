Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

if (num % 2 == 0 || num % 3 == 0 || num % 5 == 0 || num % 7 == 0 || num % 11 == 0)
{
    Console.WriteLine("Число не простое.");
}
else
{
    Console.WriteLine("Число простое.");
}

Console.WriteLine("\nВведите диапозон.");
Console.Write("От: ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int b = Convert.ToInt32(Console.ReadLine());

for (int i = a; i <= b; i++)
{
    if(i == 2 ||  i == 3 || i == 5|| i == 7 || i == 11)
    {
        Console.WriteLine(i);
    }
    else
    {

        if (!(i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0 || i % 11 == 0))
        {
            Console.WriteLine(i);
        }
    }
    
}
// Задайте значение N. Напишите программу, которая найдет факториал 
// числа N рекурсивным методом. N = 4 -> 24

int Factorial(int f)
{
    if(f > 1)
    {
        return f * Factorial(f - 1);
    }
    return 1;
}
Console.WriteLine();
Console.Write("Input a factorial number n: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The factorial of number {f}! = {Factorial(f)}");
Console.WriteLine();

// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNaturElments(int m, int n)
{
    //int sum = 0;
    if (n > m)
    {
        return n + SumOfNaturElments(m, n - 1);
    }
    return m;
}
Console.Write("Input a minimal number of range m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum number of range n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of numbers from {m} to {n} is: {SumOfNaturElments(m, n)}");
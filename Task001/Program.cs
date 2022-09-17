// Напишите ЦИКЛ, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

// Возводим число A в натуральную степень B
double GetPowNum(int a, int b)
{
    double result = a;
    if (b == 0)
    {
        result = 1;
    }
    else if (b < 0)
    {
        result = Math.Pow(a, b);
    }
    else
    {
        for (int i = 2; i <= b; i++)
        {
            result = result * a;
        } 
    }
    return result;
}

// Определяем входные числа
Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число В: ");
int B = int.Parse(Console.ReadLine());

double powNum = GetPowNum(A, B);
Console.WriteLine($"{A} в степени {B} = {powNum}");

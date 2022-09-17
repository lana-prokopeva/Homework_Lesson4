// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Определяем сумму цифр числа
int GetSumNumbers(int numbers)
{
    int sum = 0;
    if (numbers < 0) numbers = numbers * (-1);
    while (numbers > 0)
    {
        int x = numbers%10;
        sum = sum + x;
        numbers = (numbers - x)/10;   
    }
    return sum;
}

// Определяем входное число
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int sum = GetSumNumbers(num);
Console.WriteLine($"Сумма цифр в числе = {sum}");

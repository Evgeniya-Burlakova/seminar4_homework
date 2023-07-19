// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чифр числа {n} равна {SumNumbers(n)}");
int SumNumbers(int numb)
{
    if (numb < 0)
        numb *= (-1);
    int sum = 0;
    while (numb > 0)
    {
        sum = sum + numb % 10;
        numb /= 10;
    }
    return sum;
}
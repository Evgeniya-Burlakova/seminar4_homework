// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
while (b < 1)
{
    Console.Write("Введеное число B не натуральное, попробуй ещё: ");
    b = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Число {a} в степени {b} равно {Power(a, b)}");

int Power(int firstNumber, int secondNumber)
{
    int pow = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        pow = pow * firstNumber;
    }
    return pow;
}

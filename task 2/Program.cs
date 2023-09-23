// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

int FindSum(int a)
{
    int summ = 0;
    while (a>0)
    {
        summ += a % 10;
        a = a / 10;
    }
    Console.Write(summ);
    return summ;
}

int a = WorkWithUser("Введите число: ");
FindSum(a);
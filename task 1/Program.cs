// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

double FindNum(int a, int b)
{
    double num = Math.Pow(a, b);
    Console.Write(num);
    return num;
}

int a = WorkWithUser("Введите число a: ");
int b = WorkWithUser("Введите число b: ");

FindNum(a,b);
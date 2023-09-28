// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Random generator = new Random();
int[] numbers = new int[8];
Console.Write("[");
for (int i = 0; i<8; i++)
{
    numbers[i] = generator.Next(1, 51);
}
for (int j = 0; j<7; j++)
{
    Console.Write(numbers[j] + ", ");
}
Console.Write(numbers[7]);
Console.Write("]");
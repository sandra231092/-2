// Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = (number % 100 / 10);

if (number >= 100 & number < 1000)
{
    Console.Write($"Вторая цифра данного числа = {digit2}");
}
else
{
    Console.Write("Вторая цифра в данном числе отсутствует");
}

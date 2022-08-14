//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int digitIndex= 2;
string number3 = Console.ReadLine();

if (number3.Length > 0)
{
    if (number3[0] == '-')
    {
        digitIndex++;
    }
}
if (number3.Length <= digitIndex)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(number3[digitIndex]);
}
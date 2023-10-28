//Задача 13: Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 999)
{
    number /= 10;  
}
if(number > 99 && number < 1000)
{
    Console.Write(number % 10);
}
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
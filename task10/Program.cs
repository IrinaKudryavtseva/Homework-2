//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8

int number1 = new Random().Next(100,1000);
Console.WriteLine(number1);
int number2 = number1 % 100;
int number3 = number2 / 10;

Console.WriteLine(number3);


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//7 -> да
//1 -> нет
Console.WriteLine("Введите цифру от 1-7");
string number = Console.ReadLine();
if(number == "1"|| number == "2"|| number == "3"|| number == "4" || number == "5")
{
    Console.WriteLine ("Нет");
}
else if(number == "6"|| number == "7" )
{Console.WriteLine ("Да");
}
else
{
    Console.WriteLine("Вы ввели не с 1 до 7");
}
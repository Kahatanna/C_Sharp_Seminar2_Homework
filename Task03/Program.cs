/*

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/

Console.Write("Введите номер дня недели: ");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek == 6 || dayOfWeek == 7)
{
    Console.WriteLine("Это выходной!!!");
}
else if (dayOfWeek > 0 && dayOfWeek < 6)
{
    Console.WriteLine("Это будний день ((");
}
else
{
    Console.WriteLine("Такого дня недели пока нету..");
}
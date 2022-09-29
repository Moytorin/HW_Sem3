//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Enter number ");
string s1 = new String (Console.ReadLine());
if (s1[0] == s1[4] && s1[1] == s1[3])
{
    Console.WriteLine("Number is palindrom");
}
else
{
    Console.WriteLine("Number isn't palindrom");
}

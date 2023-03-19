/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// палиндром - читаются одинаково слева направо и наоборот

Console.Write("Введите значение");
string number1 = Console.ReadLine();

if (number1[0] == number1[4] && number1[1] == number1[3])
{
    Console.WriteLine($"Число {number1} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number1} не является палиндромом");
}

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите X точки A = ");
int XA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки A = ");
int YA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки A = ");
int ZA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X точки B = ");
int XB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y точки B = ");
int YB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z точки B = ");
int ZB = Convert.ToInt32(Console.ReadLine());

double number = Math.Sqrt((Math.Pow((XA - XB), 2)) + (Math.Pow((YA - YB), 2)) + (Math.Pow((ZA-ZB), 2)));
Console.WriteLine(number);


Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
*/

Console.Write("Введите число N = ");
int N = Convert.ToInt32(Console.ReadLine());

for (int count = 1; count <= N; count++)
{
    Console.Write(Math.Pow(count, 3) + " ");
}
﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int userNumberFirst = new int ();
int userNumberSecond = new int ();
int userNumberThird = new int ();
int max = new int ();
Console.WriteLine ("Введите первое число");
userNumberFirst=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число");
userNumberSecond=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите третье число");
userNumberThird = Convert.ToInt32 (Console.ReadLine ());
max = userNumberFirst;
if (userNumberSecond> userNumberFirst)
{
max=userNumberSecond;
}
if (userNumberThird>userNumberSecond)
{
     max=userNumberThird;
}
if (userNumberFirst>userNumberThird)
{
    max=userNumberFirst;
}
    Console.WriteLine ($"максимальное число равно:" + max);

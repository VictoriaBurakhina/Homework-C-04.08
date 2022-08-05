// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int userNumberFirst = new int ();
int userNumberSecond = new int ();
Console.WriteLine ("Введите первое число");
userNumberFirst=Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число");
userNumberSecond=Convert.ToInt32 (Console.ReadLine());
if (userNumberFirst > userNumberSecond)
{
    Console.WriteLine ($"max = число {userNumberFirst}, min = число {userNumberSecond}");
}
else
{
    Console.WriteLine ($" min = число {userNumberFirst}, max = число {userNumberSecond}");
}

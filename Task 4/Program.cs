// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int UserNumber = new int ();
int Number = 2;
Console.WriteLine ("Введите число");
UserNumber= Convert.ToInt32 (Console.ReadLine());
while (Number<=UserNumber)
{
Console.Write (Number );
Number+=2;
}

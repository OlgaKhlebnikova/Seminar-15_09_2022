// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//  5 -> 2, 4
//  8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите число");
int namber = int.Parse(Console.ReadLine());
for (int i = 1; i <= namber; i++)
{
    if (i %2 == 0)
       Console.Write( i + " ");
     } 
 Console.WriteLine(" - Это четные числа в промежутке от 1 до " + namber + ".");
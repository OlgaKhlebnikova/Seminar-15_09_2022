// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите число");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int namber2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int namber3 = int.Parse(Console.ReadLine());

if (namber1 > namber2 && namber1 > namber3 )
{
    Console.WriteLine("Наибольшим числом является число " + namber1);
} 
else if (namber2 > namber1 && namber2 > namber3 )
{
   Console.WriteLine("Наибольшим числом  является число " + namber2);
}
else 
{
    Console.WriteLine("Наибольшим числом  является число " + namber3);
}
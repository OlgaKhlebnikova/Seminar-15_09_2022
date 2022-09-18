// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


Console.Clear();
Console.WriteLine("Введите число");
int namber = int.Parse(Console.ReadLine());

if (namber %2 == 0)
{
    Console.WriteLine("Число " + namber + " является четным числом ");
} 
else 
{
   Console.WriteLine("Число " + namber + " является нечетным числом ");
}

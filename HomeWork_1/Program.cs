// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите число");
int namber1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число");
int namber2 = int.Parse(Console.ReadLine());
if (namber1 > namber2)
{
    Console.WriteLine("Наибольшим числом из чисел " + namber1 + " и " + namber2 + " является число " + namber1);
} 
else if (namber1 == namber2)
{
   Console.WriteLine("Числа равны ");
}
else
{
    Console.WriteLine("Наибольшим числом из чисел " + namber1 + " и " + namber2 + " является число " + namber2);
}
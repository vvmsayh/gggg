//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
System.Console.Write("введите число ");
int number = System.Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0 )
{
    System.Console.WriteLine("число является чeтным" );
}
else
{
    System.Console.WriteLine("число является нечетным");
}
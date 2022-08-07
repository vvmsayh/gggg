//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
System.Console.WriteLine("введите первое число ");
int first_number = System.Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число ");
int second_number = System.Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите третье число ");
int third_number = System.Convert.ToInt32(Console.ReadLine());
int max = first_number; 
if(second_number>max) max = second_number;
if (third_number>max) max = third_number;
System.Console.WriteLine("Максимальное число - " + max);

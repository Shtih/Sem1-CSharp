//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С: ");
int C = Convert.ToInt32(Console.ReadLine());

if(A>B && A>C)
{
    Console.Write($"{A} является максимальным");
}
else if(B>A && B>C)
{
    Console.Write($"{B} является максимальным");
}
else if(C>B && C>A)
{
    Console.Write($"{C} является максимальным");
}
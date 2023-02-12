// задача: написать программу которая выводит квадрат числа
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = 0;
square = number * number;
Console.Write($"Квадрат числа {number} = {square}");
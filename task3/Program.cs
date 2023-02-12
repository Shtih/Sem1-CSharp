//Задача №3. Напишите программу, которая будет выдавать название 
//дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница
Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.WriteLine("Mondey");  
}
else if (day == 2)
{
    Console.WriteLine("Tusday");
}
else if (day == 3)
{
    Console.WriteLine("Wensday");
}
else if (day == 4)
{
    Console.WriteLine("Thasday");
}
else if (day == 5)
{
    Console.WriteLine("Friday");
}
else if (day == 6)
{
    Console.WriteLine("Saterday");
}
else if (day == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Wrong imput");
}
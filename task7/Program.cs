// SЗадача №7. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введите трехзначное число: ");
int numberA  = Convert.ToInt32(Console.ReadLine());
int LastNumber = 0;
if(numberA > 99 && numberA < 1000)
{
    LastNumber = numberA%10;
    Console.Write(LastNumber);
}
else
{
    Console.Write("Imposible imput");
}

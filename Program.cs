// 1.
// Задача 10: На9пишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(( num < 100) && (num > 1000))
{
    Console.WriteLine("Это неверное число. Вернитесь в начало.");
}
else
{
        int num1 = num / 10;
        int num2 = num1 % 10;
        Console.WriteLine(num2);
}
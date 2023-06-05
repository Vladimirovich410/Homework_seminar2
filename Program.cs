// 1.
// Задача 10: На9пишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Введите трёхзначное число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(( num < 100) || (num > 1000))
// {
//     Console.WriteLine("Это неверное число. Вернитесь в начало.");
// }
// else
// {
//         int num1 = num / 10;
//         int num2 = num1 % 10;
//         Console.WriteLine(num2);
// }

// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает,
//  что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if((num > 99) && (num < 1000))
{
    int num1 = num % 10;
    Console.WriteLine(num1);
}
else if((num > 999) && (num < 10000))
{
    int num2 = (num / 10) % 10;
    Console.WriteLine(num2);
}
else if((num > 9999) && (num < 100000))
{
    int num3 = (num / 100) % 10;
    Console.WriteLine(num3);
}
else if((num > 99999) && (num < 1000000))
{
    int num4 = (num / 1000) % 10;
    Console.WriteLine(num4);
}
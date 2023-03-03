
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1



// int SecondNumber (int num)
// {
//     int secnum = 0;
//     if (num > 100 && num < 1000)
//     {
//     int two = num % 100;
//     secnum = two / 10;
//     }
//     else return -1;
//     return secnum;
    
// }

// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"The second number of the number {number} -> {(SecondNumber(number))}");


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// int ThirdNumber (int num)
// {
//     int third1 = -1;
//     while ( num > 999)
//     {
//         num = num /10;
//     }
//         if (num >= 100 && num < 1000)
//             {
//                 third1 = num % 100;
//                 third1 = third1 % 10;
//             }
//     return third1;
// }
// Console.WriteLine("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// if (ThirdNumber(number) == -1)
//     Console.WriteLine($"{number} -> третьей цифры нет");
// else 
//     Console.WriteLine ($"The third number of the number {number} -> {(ThirdNumber(number))}");


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// string Weekend(int num)
// {
//     if(num == 0 || num >7)
//     {
//         return "this number is not the day of the week";
//     }
//     if(num == 6 || num == 7)
//     return "yes";
//     else return "no";
// }
// Console.WriteLine("Input day of the week");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ($"day of the week off {number}? -> {(Weekend(number))}");
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Enter three digit number ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);

// Console.WriteLine($"The second number is " +stringNumber[1]);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine ("Enter the number" );
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);

// if (NumberText.Length > 2)
// {
//     Console.WriteLine ("The third number is " +NumberText[2]);
// }
// else 
// {
//     Console.WriteLine ("Третьей цифры нет" );
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Enter the number for the day of the week" );
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber > 5 && dayNumber < 8)
    {
       Console.Write ("да");
    }
    if (dayNumber > 0 && dayNumber < 6)
    {
    Console.Write ("нет");
    }
    if (dayNumber > 7)
    {
      Console.Write ("это не день недели");  
    
    }
}
CheckingTheDayOfTheWeek (dayNumber);
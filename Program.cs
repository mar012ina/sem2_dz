// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.

void SecondDigit(int num)
{
    int res = (num / 10) % 10;
    Console.WriteLine($"Вторая цифра числа {num} равна {res}");
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondDigit(num);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string res = Convert.ToString(num);
if (res.Length > 2)
{
  Console.WriteLine("Третья цифра: " + res[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

void DayOfTheWeek(int day)
{
    if (day > 7 || day < 1)
    {
        Console.WriteLine("Введите другое число");
    }
        else{
        if (day >= 6)
        {
            Console.WriteLine("Это выходной день!!!");
        }
        else
        {
            Console.WriteLine("Это рабочий день.");
        }
        }
}


Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
DayOfTheWeek(day);


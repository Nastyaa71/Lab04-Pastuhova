Console.WriteLine("Введите число:"); 
string input = Console.ReadLine(); 
if (int.TryParse(input, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Число чётное."); 
    }
    else
    {
         Console.WriteLine("Число нечётное."); 
    }
}
else
{
    Console.WriteLine("Ошибка: введите корректное число."); 
}



Console.WriteLine("Введите оценку (от 2 до 5):");
string input = Console.ReadLine();
if (int.TryParse(input, out int grade))
{
    switch (grade)
    {
        case 5:
            Console.WriteLine("Отлично");
            break;
        case 4:
            Console.WriteLine("Хорошо");
            break;
        case 3:
            Console.WriteLine("Удовлетворительно");
            break;
        case 2:
            Console.WriteLine("Неудовлетворительно");
            break;
        default:
            Console.WriteLine("Неверная оценка");
            break;
    }
}
else
{
    Console.WriteLine("Неверная оценка");
}
    


    
string input = Console.ReadLine();
if (int.TryParse(input, out int month))
{
    switch (month)
    {
        case 12:
        case 1:
        case 2:
            Console.WriteLine("Зима");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Весна");
            break;
        case 6:
        case 7:
        case 8:
            Console.WriteLine("Лето");
            break;
        case 9:
        case 10:
        case 11:
            Console.WriteLine("Осень");
            break;
        default:
            Console.WriteLine("Неверный месяц");
            break;
    }
}
else
{
    Console.WriteLine("Неверный месяц");
}
    



string input = Console.ReadLine();
if (int.TryParse(input, out int year))
{
    bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    if (isLeapYear)
    {
        Console.WriteLine("Год високосный, в феврале 29 дней");
    }
    else
    {
        Console.WriteLine("Год не високосный, в феврале 28 дней");
    }
}
else
{
    Console.WriteLine("Неверный год");
}

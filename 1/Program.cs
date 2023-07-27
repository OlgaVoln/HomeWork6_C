// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int countPositive = CountPositiveNumbers(M);

Console.WriteLine($"Количество положительных чисел: {countPositive}");

int CountPositiveNumbers(int count)
{
    int positiveCount = 0;

    for (int i = 1; i <= count; i++)
    {
        Console.Write($"Введите число {i}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
            positiveCount++;
    }

    return positiveCount;
}



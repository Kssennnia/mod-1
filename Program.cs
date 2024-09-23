using System;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вызов метода, который запускает игру
            StartGame();
        }
        static void StartGame()
        {
            // Создание объекта для генерации случайных чисел
            Random random = new Random();
            // Генерация случайного числа от 1 до 100
            int numberToGuess = random.Next(1, 101);
            // Переменная для хранения числа, которое вводит пользователь
            int userGuess = 0;
            // Цикл продолжается до тех пор, пока пользователь не угадает число
            while (userGuess != numberToGuess)
            {
                // Вызов метода для получения числа от пользователя
                userGuess = GetUserGuess();
                // Вызов метода для проверки введенного числа и вывода подсказки
                GiveHint(userGuess, numberToGuess);
            }
            // Сообщение о том, что число угадано
            Console.WriteLine("Поздравляю! Вы угадали число.");
        }
        static int GetUserGuess()
        {
            int guess = 0;
            // Бесконечный цикл, продолжающийся до тех пор, пока пользователь не введет корректное число
            while (true)
            {
                Console.Write("Введите число от 1 до 100: ");
                string input = Console.ReadLine();
                // Проверка, является ли введенная строка числом
                if (int.TryParse(input, out guess) && guess >= 1 && guess <= 100)
                {
                    // Если ввод корректен, возвращаем число
                    return guess;
                }
                else
                {
                    // Сообщение об ошибке при неверном вводе
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
        }
        static void GiveHint(int userGuess, int numberToGuess)
        {
            // Проверка, больше ли введенное число загаданного
            if (userGuess > numberToGuess)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            // Проверка, меньше ли введенное число загаданного
            else if (userGuess < numberToGuess)
            {
                Console.WriteLine("Загаданное число больше.");
            }
        }
    }
}
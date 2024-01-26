namespace CleannetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет как тебя зовут?");
            string? name = Console.ReadLine();
            Console.WriteLine($"{name}, сейчас будем играть в 'Угадай число'. Я загадываю, ты отгадываешь");

            Random rnd = new Random();
            int guess = rnd.Next(0, 100);

            Console.WriteLine("Так, ну всё, загадал число от 0 до 99. Угадывай, а я буду подсказывать тебе!");

            bool isIntNumber = false;
            int userNumber = -1;
            bool isWin = false;
            int count = 0;

            while(!isWin) 
            {
                do
                {
                    Console.WriteLine("Введи число: ");
                    string? userInput = Console.ReadLine();
                    isIntNumber = int.TryParse(userInput, out userNumber);

                    if (!isIntNumber)
                    {
                        Console.WriteLine("Неверно введённое число. Введите число от 0 до 99");
                    }

                }
                while (!isIntNumber);


                if (userNumber == guess)
                {
                    Console.WriteLine($"Поздравляю {name}, ты угадал!");
                    ++count;
                    Console.WriteLine($"{name}, угадал число {guess} за {count} попыток!");
                    isWin = true;
                }
                else if (userNumber > guess)
                {
                    Console.WriteLine("Нет, загаданное число меньше)");
                    count++;
                }
                else
                {
                    Console.WriteLine("Нет, загаданное число больше)");
                    count++;
                }
            }

           


        }   

    }
}

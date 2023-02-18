using System.Drawing;

namespace New_5_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Кортедж anketa
            (string name, int age) anketa;
            Console.WriteLine("Enter your name: ");
            anketa.name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name is {0}", anketa.name);
            Console.WriteLine("Your age is {0}", anketa.age);

            // Код сортировки массива из метода
            var favcolor = new string[3];
            Console.WriteLine("Your favorite colors");
            for (int i = 0; i < favcolor.Length; i++)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\nIteration {0}", i + 1);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;


                favcolor[i] = ShowColor(anketa.name, anketa.age); //Передача данных из кортеджа anketa в метод Color (данные передаются в аргументы метода)

            }
            ShowFavColor(favcolor); // Передача значения массива favcolor в метод ShowFavColor. Вызов метода ShowFavColor



            Console.ReadKey();
        }
        static void ShowFavColor(string[] colors) // Перечисление всех введенных цветов пользователя вынесено в отдельный метод.
                                                  // Просиходит получение значения массива favcolor в метод ShowFavColor.
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\nYour favorite colors:");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
        static string ShowColor(string username, int userage) // Инициализация метода и прием в метод значений из кортеджа anketa
        {

            Console.Write("{0}, {1} years old. Enter your color: ", username, userage); // Использование данных из метада, взятых из кортеджа
            string color = new(Console.ReadLine());

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;


                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "dark blue":
                    Console.BackgroundColor = ConsoleColor.DarkBlue; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "violet":
                    Console.BackgroundColor = ConsoleColor.DarkMagenta; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.White; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                case "white":
                    Console.BackgroundColor = ConsoleColor.White; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Black; // свойство цвета шрифта.
                    Console.WriteLine("Your color is " + color);
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow; // свойство цвета фона консоли (не всего, а того, который у наших данных).
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry color {0} not found in database", color);
                    break;
            }
            return color;


        }
    }
}
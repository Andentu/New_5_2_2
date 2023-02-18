namespace New_5_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var favcolor = new string[3];
            Console.WriteLine("Your favorite colors");
            for (int i = 0; i < favcolor.Length; i++)
            {

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("\nIteration {0}", i + 1);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("Enter your color: ");
                favcolor[i] = ShowColor();
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\nYour favorite colors:");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var color in favcolor)
            {
                Console.WriteLine(color);
            }
            Console.ReadKey();
        }
        static string ShowColor()
        {

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
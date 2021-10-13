using System;

namespace ConsoleApp1
{
    class Program
    {
        /*static string[] ReadColor()
        {
            Console.WriteLine("Введите три любимых цвета:");
            string[] favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                var color = Console.ReadLine();
                favcolors[i] = color;
                switch (color)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Your color is yellow!");
                        break;
                }
            }

            return favcolors;
        }
        static void ShowColor (string username, params string[] favcolors)
        {
            Console.WriteLine("{0}, Ваши любимые цвета:",username);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }*/

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray (int[] sort)
        {
            int temp = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i] > sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }
            return sort;
        }
        static void ShowArray (int[] array, bool sortattribute = false)
        {
            if (sortattribute)
            {
                SortArray(array);
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("Внимание сортировка невозможны!!");
            }
        }
        static void Main(string[] args)
        {
            /*var (name, age) = ("Георгий", 35);

            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите возрас с цифрами:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            string[] favcolors = new string[3];
            favcolors = ReadColor();
            ShowColor(name, favcolors);*/
            int[] array = GetArrayFromConsole(10);
            ShowArray(array, true);
        }
        
    }
}

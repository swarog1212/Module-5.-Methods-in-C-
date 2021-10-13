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

        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static void SortArray (int[] sort, out int[] sorteddesc, out int[] sortedasc)
        {
            sorteddesc = SortArrayDesc(sort);
            ShowArray(sort, true);
            Console.WriteLine();
            sortedasc = SortArrayAsc(sort);
            ShowArray(sort, true);
        }
        static int[] SortArrayDesc (int[] sort)
        {
            int temp = 0;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = i + 1; j < sort.Length; j++)
                {
                    if (sort[i] < sort[j])
                    {
                        temp = sort[i];
                        sort[i] = sort[j];
                        sort[j] = temp;
                    }
                }
            }
            return sort;
        }
        static int[] SortArrayAsc (int[] sort)
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
            var nam = 10;
            int[] array = GetArrayFromConsole(ref nam);
            int[] sorteddesc;
            int[] sortedasc;
            SortArray(array, out sorteddesc, out sortedasc);
        }    
        
    }
}

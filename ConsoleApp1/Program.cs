using System;

namespace ConsoleApp1
{
    class Program
    {
        static (string name, string lastName, int age, bool availPets, string[] namePet, string[] favorColors)EnterUser()
        {
            (string name, string lastName, int age, bool availPets, string[] namePet, string[] favorColors) user;
            string userName;
            int intUserName;
            do
            {
                Console.WriteLine("Введите имя");
                userName = Console.ReadLine();
            } while (CheckNumberAndString(userName, out intUserName));
            user.name = userName;

            string userLastName;
            int intUserLastName;
            do
            {
                Console.WriteLine("Введите фамилию");
                userLastName = Console.ReadLine();
            } while (CheckNumberAndString(userLastName, out intUserLastName));
            user.lastName = userLastName;

            string age;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();
            } while (CheckNumberAndString(age, out intage) != true);
            user.age = intage;

            Console.WriteLine("Есть ли у вас домашние животные? да или нет");
            var unswer = Console.ReadLine();
            string numPets;
            int intNumPets;
            user.availPets = true;
            user.namePet = null;
            if (unswer == "да")
            {
                do
                {
                    Console.WriteLine("Введите количество домашних животных цифрами");
                    numPets = Console.ReadLine();
                } while (CheckNumberAndString(numPets, out intNumPets) != true);
                user.namePet = new string[intNumPets];

                Console.WriteLine("А теперь введите клички каждого из них");
                for (int i = 0; i < user.namePet.Length; i++)
                {
                    string name;
                    int intName;
                    do
                    {
                        Console.Write("Кличка {0}-го питомца: ", i + 1);
                        name = Console.ReadLine();
                    } while (CheckNumberAndString(name, out intName));
                    user.namePet[i] = name;
                }
            }
            else
            {
                user.availPets = false;
            }

            string favColors;
            int intFavColors;
            do
            {
                Console.WriteLine("Введиет количество любимых цветов");
                favColors = Console.ReadLine();
            } while (CheckNumberAndString(favColors, out intFavColors) != true);
            user.favorColors = new string[intFavColors];

            Console.WriteLine("Введите название каждого цвета");
            for (int i = 0; i < user.favorColors.Length; i++)
            {
                string nameColor;
                int intNameColor;
                do
                {
                    Console.Write("Название {0}-го цвета: ", i + 1);
                    nameColor = Console.ReadLine();
                } while (CheckNumberAndString(nameColor, out intNameColor));
                user.favorColors[i] = nameColor;
            }
            return user;
        }
        static void ShowUser ((string name, string lastName, int age, bool availPets, string[] namePet, string[] favorColors)user)
        {
            
            Console.WriteLine("Ваше имя: {0}", user.name);
            Console.WriteLine("Ваша фамилия: {0}", user.lastName);
            Console.WriteLine("Ваш возраст: {0}", user.age);
            if (user.availPets)
            {
                Console.WriteLine("Количество ваших домашних животных: {0}", user.namePet.Length);
                Console.Write("Имена выших домашних животных: ");
                foreach (var pets in user.namePet)
                {
                    Console.Write(pets + ", ");
                }
            }
            else
            {
                Console.Write("Домашние животные отсутствуют!");
            }
            Console.WriteLine();
            Console.WriteLine("Количество выших любимых цветов: {0}", user.favorColors.Length);
            Console.Write("Названия ваших любимых цветов: ");
            foreach (var color in user.favorColors)
            {
                Console.Write(color + ", ");
            }
            Console.WriteLine();
        }
        static bool  CheckNumberAndString (string number, out int corrnum)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnum = intnum;
                    return true;
                }
            }
            {
                corrnum = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            var user = EnterUser();
            Console.WriteLine();
            ShowUser(user);
        }    
        
    }
}

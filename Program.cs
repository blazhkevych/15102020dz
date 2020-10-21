using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _15102020dz
{
    class Program
    {
        static void Main(string[] args)
        {
            // How to search strings
            // - https://docs.microsoft.com/en-us/dotnet/csharp/how-to/search-strings

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("ЗАВДАННЯ:" +
     "\nКористувач вводить рядок, який складається з символів. " +
     "\nСимволи складаються в слова, які розділяються розділовими знаками. " +
     "\nСлова відокремлюються одним або  декількома пробілами. " +
     "\nВиконати обробку рядка відповідно до завдання.\n" +
     "\n1. Надрукувати найдовше і найкоротше слово в цьому рядку." +
     "\n2. Надрукувати всі слова, які не містять голосних букв." +
     "\n3. Надрукувати всі слова, які складаються лише з цифр." +
     "\n4. Надрукувати всі слова, які збігаються з першим словом." +
     "\n5. Перетворити рядок так, щоб всі букви в кожному слові були відсортовані за  алфавітом." +
     "\n6. Перетворити рядок так, щоб всі слова були відсортовані за алфавітом у  зворотному порядку." +
     "\n7. Прибрати з рядка всі зазначені символи, які введе користувач." +
     "\n8. Підрахувати частоту входження символів у введеному тексті. Відсортуйте  статистику за спаданням.");
            //Console.WriteLine("\nВведіть рядок, який складається з символів: ");
            //string[] input = Console.ReadLine().Split(new char[] { ',', '.', ' ' },
            //                 StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("\nОзнайомитися з особливостями створення класів, полів, конструкторів,  статичних елементів класу, набуття практичних навичок роботи з методами. 123 Ознайомитися\n");
            string[] input =
"Ознайомитися з особливостями створення класів, полів, конструкторів,  статичних елементів класу, набуття практичних навичок роботи з методами. 123 Ознайомитися"
                    .Split(new char[] { ',', '.', ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Оберіть варіант обробки рядка:");
            while (true)
            {
                char s = Console.ReadKey().KeyChar;
                switch (s)
                {
                    case '1': //1. Надрукувати найдовше і найкоротше слово в цьому рядку.
                        Console.WriteLine(" :");
                        var sorted = input.OrderBy(n => n.Length);
                        var shortest = sorted.FirstOrDefault();
                        var longest = sorted.LastOrDefault();
                        Console.WriteLine($"найкоротше = {shortest}, найдовше = {longest}");
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '2': //2. Надрукувати всі слова, які не містять голосних букв.
                        Console.WriteLine(" :");
                        char[] any = { 'а', 'е', 'и', 'і', 'о', 'у', 'я', 'ю', 'є', 'ї' };
                        foreach (var el in input)
                        {
                            if (el.IndexOfAny(any) == -1)
                                Console.WriteLine(el);
                        }
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '3': //3. Надрукувати всі слова, які складаються лише з цифр.
                        Console.WriteLine(" :");
                        char[] any2 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                        foreach (var el in input)
                        {
                            if (el.IndexOfAny(any2) == 0)
                                Console.WriteLine(el);
                        }
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '4': //4. Надрукувати всі слова, які збігаються з першим словом.
                        Console.WriteLine(" :");
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input[0] == input[i])
                                Console.WriteLine(input[i]);
                        }
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '5': //5. Перетворити рядок так, щоб всі букви в кожному слові були відсортовані за  алфавітом.
                        Console.WriteLine(" :");

                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '6': //6. Перетворити рядок так, щоб всі слова були відсортовані за алфавітом у  зворотному порядку.
                        Console.WriteLine(" :");

                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '7': //7. Прибрати з рядка всі зазначені символи, які введе користувач.
                        Console.WriteLine(" :");
                        string userInput = ("Прибрати з рядка всі зазначені символи, які введе користувач.");
                        var symbolToDelete = Console.ReadLine().ToCharArray();
                        userInput = new string(userInput.Where(x => !symbolToDelete.Contains(x)).ToArray());
                        Console.WriteLine(userInput);
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    case '8': //8. Підрахувати частоту входження символів у введеному тексті. Відсортуйте  статистику за спаданням.
                        string text = "Підрахувати частоту входження символів у введеному тексті. " +
              "Відсортуйтестатистику за спаданням";
                        Console.WriteLine(" :");
                        //масив кортежів для символа і статистики
                        (char symbol, int count)[] res = new (char, int)[text.Distinct().Count()];
                        int size = 0;
                        foreach (var el in text.Distinct())
                        {
                            int count = text.Count(x => x == el);
                            res[size++] = (el, count);
                        }

                        res = res.OrderByDescending(x => x.count).ToArray();
                        foreach (var el in res)
                        {
                            Console.WriteLine($"{el.symbol} = {el.count}");
                        }
                        Console.WriteLine("Оберіть варіант обробки рядка:");
                        break;
                    default:
                        break;
                }
                //Console.Clear();
            }
        }
    }
}

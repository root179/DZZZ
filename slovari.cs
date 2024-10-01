class Program
{
    static void Main(string[] args)
    {



        Dictionary<string, string> dict = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("1. Добавить");
            Console.WriteLine("2. Найти номер");
            Console.WriteLine("3. Вывести все записи");
            Console.WriteLine("4. Выход");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("Введите номер:");
                    string num = Console.ReadLine();
                    Console.WriteLine("Введите имя:");
                    string name = Console.ReadLine();

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, num);
                        Console.WriteLine("Запись добавлена.");
                    }
                    else
                    {
                        Console.WriteLine("Запись с таким именем уже существует.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Введите имя:");
                    string findName = Console.ReadLine();

                    if (dict.ContainsKey(findName))
                    {
                        Console.WriteLine("Номер телефона: " + dict[findName]);
                    }
                    else
                    {
                        Console.WriteLine("Запись не найдена.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Все записи:");
                    foreach (KeyValuePair<string, string> entry in dict)
                    {
                        Console.WriteLine("Имя: " + entry.Key + ", Номер: " + entry.Value);
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
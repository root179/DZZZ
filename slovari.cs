class Program
{
    static void Main(string[] args)
    {



        Dictionary<string, string> dict = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("1. ��������");
            Console.WriteLine("2. ����� �����");
            Console.WriteLine("3. ������� ��� ������");
            Console.WriteLine("4. �����");

            string menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Console.WriteLine("������� �����:");
                    string num = Console.ReadLine();
                    Console.WriteLine("������� ���:");
                    string name = Console.ReadLine();

                    if (!dict.ContainsKey(name))
                    {
                        dict.Add(name, num);
                        Console.WriteLine("������ ���������.");
                    }
                    else
                    {
                        Console.WriteLine("������ � ����� ������ ��� ����������.");
                    }
                    break;

                case "2":
                    Console.WriteLine("������� ���:");
                    string findName = Console.ReadLine();

                    if (dict.ContainsKey(findName))
                    {
                        Console.WriteLine("����� ��������: " + dict[findName]);
                    }
                    else
                    {
                        Console.WriteLine("������ �� �������.");
                    }
                    break;

                case "3":
                    Console.WriteLine("��� ������:");
                    foreach (KeyValuePair<string, string> entry in dict)
                    {
                        Console.WriteLine("���: " + entry.Key + ", �����: " + entry.Value);
                    }
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("�������� �����, ���������� �����.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
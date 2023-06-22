Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя: ");
string username = Console.ReadLine();
Console.WriteLine("Привет, ");
Console.WriteLine(username);
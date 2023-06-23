Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "надя")

{
    Console.WriteLine ("Ура, Моя Надюшка пришла!!!");

}
else
{
    Console.Write ("Привет, " );
    Console.WriteLine (username);
}
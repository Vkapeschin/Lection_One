Console.WriteLine("Введите имя пользователя, ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Маша, ура-ура!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
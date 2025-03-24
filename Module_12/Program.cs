namespace Module_12;

class Program
{
    static void Main(string[] args)
    {
        var users = new User[]
        {
            new()
            {
                Login = "Ivan333",
                Name = "Иван",
                IsPremium = false
            },
            new()
            {
                Login = "Stepan",
                Name = "Степан",
                IsPremium = false
            },
            new()
            {
                Login = "Bibi",
                Name = "Альбина",
                IsPremium = true
            }
        };

        for (var i = 0; i < users.Length; i++)
        {
            if (!users[i].IsPremium)
                ShowAds();
            Console.WriteLine($"Привет, {users[i].Name}!");
            Console.WriteLine();
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    static void ShowAds()
    {
        Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
        Thread.Sleep(1000);

        Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
        Thread.Sleep(2000);

        Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
        Thread.Sleep(3000);
    }
}
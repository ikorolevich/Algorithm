namespace UserList
{
    internal class Program
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }

        static void Main(string[] args)
        {
            int userCount = 10;
            List<User> users = new List<User>(userCount);
            for (int i = 0; i < userCount; i++)
            {
                User user = new User();
                if (i % 2==0)
                {
                    user.IsPremium = true;
                }
                else
                {
                    user.IsPremium = false;
                }
                user.Name = "Name" + i.ToString();
                user.Login = "Login" + i.ToString();
                users.Add(user);
            }
            foreach (var usr in users)
            {
                Console.WriteLine("Hello {0}",usr.Name);
                if (!usr.IsPremium)
                {
                    ShowAds();
                }
                Console.WriteLine();
            }
        }
    }
}

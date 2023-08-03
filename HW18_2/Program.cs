namespace HW18_2
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = new List<string>() { "Earth", "Лимония", "Mars", "Venus" };
            PlanetCatalog planetCatalog = new PlanetCatalog();
            for (int i = 0; i < 30; i++) // 30 запросов на получение планеты, взятых случайным образом
            {
                var item = list[new Random().Next(0, list.Count)];
                (int NumFromSun, int EquatorLength, string NameOrException) tuple = planetCatalog.GetPlanet(item);
                if (tuple.NumFromSun == 0)
                    Console.WriteLine(tuple.NameOrException);
                else Console.WriteLine($"Планета {tuple.NameOrException} " +
                    $"имеет порядковый номер {tuple.NumFromSun} от Солнца и длину экватора {tuple.EquatorLength}");
            }
            Console.ReadLine();
        }
    }
}
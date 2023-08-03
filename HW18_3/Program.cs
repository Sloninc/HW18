namespace HW18_3
{
    internal class Program
    {
        static void Main()
        {
            List<string> list = new List<string>() { "Earth", "Лимония", "Mars", "Venus" };
            int count = 0;
            PlanetCatalog planetCatalog = new PlanetCatalog();
            var freqRequest = "вы спрашиваете слишком часто";
            for (int i = 0; i < 30; i++)  // 30 запросов на получение планеты, взятых случайным образом
            {
                var item = list[new Random().Next(0, list.Count)];
                (int NumFromSun, int EquatorLength, string NameOrException) tuple = // в метод передается лямбда-выражение
                    planetCatalog.GetPlanet(item, x =>                              // которое проверяет на запретную планету и частые запросы
                    {
                        count++;
                        if (count % 3 == 0)
                            return freqRequest;
                        string? s = planetCatalog.Find(x);
                        if (s == null) return "Это запретная планета";
                        else return null;
                    });
                if (tuple.NumFromSun == 0)
                    Console.WriteLine(tuple.NameOrException);
                else Console.WriteLine($"Планета {tuple.NameOrException} " +
                    $"имеет порядковый номер {tuple.NumFromSun} от Солнца и длину экватора {tuple.EquatorLength}");
            }
            Console.ReadLine();
        }
    }
}

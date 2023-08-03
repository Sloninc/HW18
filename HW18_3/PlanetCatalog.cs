using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW18_2;

namespace HW18_3
{
    /// <summary>
    /// Католог планет, который инициирует и хранит экземпляры планет во внутреннем списке.
    /// </summary>
    public class PlanetCatalog
    {
        List<Planet> _planets = new();
        Planet _venus, _earth, _mars;
        public PlanetCatalog()
        {
            _venus = new Planet("Venus", 2, 38025);
            _planets.Add(_venus);
            _earth = new Planet("Earth", 3, 40075, _venus);
            _planets.Add(_earth);
            _mars = new Planet("Mars", 4, 21344, _earth);
            _planets.Add(_mars);
        }
        /// <summary>
        /// Возвращает планету, если таковая имеется в списке планет либо ошибку
        /// </summary>
        /// <param name="namePlanet"> Название планеты</param>
        /// <param name="func">лямбда-выражение, которое проверяет на соответствие планету, введенную пользователем</param>
        /// <returns></returns>
        public (int, int, string) GetPlanet(string namePlanet, Func<string, string>? func)
        {
            string? answer = func(namePlanet);
            if (answer != null)
            {
                return (0, 0, answer);
            }
            else
            {
                var planet = _planets.Find(x => x.Name == namePlanet);
                return (planet.NumFromSun, planet.EquatorLength, planet.Name);
            }

        }
        /// <summary>
        /// Возвращает название планеты, если таковая имеется в списке либо null
        /// </summary>
        /// <param name="namePlanetFind">Название планеты</param>
        /// <returns></returns>
        public string? Find(string namePlanetFind)
        {
            return _planets.Find(x => x.Name == namePlanetFind)?.Name;
        }
    }
}


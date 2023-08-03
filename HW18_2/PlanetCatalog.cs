using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18_2
{
    /// <summary>
    /// Католог планет, который инициирует и хранит экземпляры планет во внутреннем списке.
    /// </summary>
    public class PlanetCatalog
    {
        List<Planet> _planets = new();
        Planet _venus, _earth, _mars;
        int _count = 0;
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
        /// <param name="namePlanet">Название планеты</param>
        /// <returns></returns>
        public (int, int, string) GetPlanet(string namePlanet)
        {
            _count++;
            if (_count % 3 == 0)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
            }
            var planet = _planets.Find(x => x.Name == namePlanet);
            if (planet == null)
                return (0, 0, "Не удалось найти планету");
            else return (planet.NumFromSun, planet.EquatorLength, planet.Name);
        }
    }
}


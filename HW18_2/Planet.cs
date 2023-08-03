using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW18_2
{
    /// <summary>
    /// Класс для создания экземпляров планет.
    /// </summary>
    public class Planet
    {
        public Planet(string name, int numFromSun, int equatorLength, Planet? previousPlanet = null)
        {
            Name = name;
            NumFromSun = numFromSun;
            EquatorLength = equatorLength;
            PreviousPlanet = previousPlanet;
        }
        /// <summary>
        /// название планеты
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// порядковый номер планеты от Солнца
        /// </summary>
        public int NumFromSun { get; }
        /// <summary>
        /// длина экватора планеты
        /// </summary>
        public int EquatorLength { get; }
        /// <summary>
        /// предыдущая планеты по порядковому номеру
        /// </summary>
        public Planet? PreviousPlanet { get; }
    }
}


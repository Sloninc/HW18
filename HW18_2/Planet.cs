namespace HW18_2
{
    /// <summary>
    /// Класс для создания экземпляров планет.
    /// </summary>
    public class Planet
    {
        private static Planet? _tempPlanet = null;
        public Planet(string name, int numFromSun, int equatorLength)
        {
            Name = name;
            NumFromSun = numFromSun;
            EquatorLength = equatorLength;
            if (_tempPlanet == null)
                PreviousPlanet = null;
            else PreviousPlanet = _tempPlanet;
            _tempPlanet = this;
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

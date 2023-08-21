using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace HW18_1
{
    internal class Program
    {
        static void Main()
        {
            var Venus = new
            {
                Name = "Venus",
                NumFromSun = 2,
                EquatorLength = 38025,
                PreviousPlanet = (object?)null 
            };


            var Earth = new
            {
                Name = "Earth",
                NumFromSun = 3,
                EquatorLength = 40075,
                PreviousPlanet = Venus
            };


            var Mars = new
            {
                Name = "Mars",
                NumFromSun = 4,
                EquatorLength = 21344,
                PreviousPlanet = Earth
            };


            var Venus2 = new
            {
                Name = "Venus",
                NumFromSun = 2,
                EquatorLength = 38025,
                PreviousPlanet = (object?)null
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };


            string VenusEquivalent(object Planet)
            {
                if (Planet.Equals(Venus))
                    return $"{Planet.GetType().GetProperty("Name")?.GetValue(Planet)} эквивалентна Венере";
                else return $"{Planet.GetType().GetProperty("Name")?.GetValue(Planet)} неэквивалентна Венере";
            }

            Console.WriteLine($"Планета Венера {JsonSerializer.Serialize(Venus, options)}\n{VenusEquivalent(Venus)}\n\n" +
                              $"Планета Земля {JsonSerializer.Serialize(Earth, options)}\n{VenusEquivalent(Earth)}\n\n" +
                              $"Планета Марс {JsonSerializer.Serialize(Mars, options)}\n{VenusEquivalent(Mars)}\n\n" +
                              $"Планета Венера {JsonSerializer.Serialize(Venus2, options)}\n{VenusEquivalent(Venus2)}");

            Console.ReadLine();
        }
    }
}
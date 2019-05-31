using Entities;
using Entities.Animlas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TestReflectionAndGenerycs();
            // Testing.TestSql();
            Console.ReadKey();
        }

        private static void TestReflectionAndGenerycs()
        {
            Console.WriteLine(Guid.NewGuid().ToString().Length);
            var animalManager = new AnimalManager<Dog> { Id = Guid.NewGuid() };
            var animals = new List<Dog>
            {
                new Dog(Guid.NewGuid(), "Firulais", "Golden", 43),
                new Dog(Guid.NewGuid(), "Paco", "Caniche", 12),
                new Dog(Guid.NewGuid(), "Paco", "Caniche" ,2),
                new Dog(Guid.NewGuid(), "Paco", "Caniche", 13),
                new Dog(Guid.NewGuid(), "Paco", "Caniche", 1),
                new Dog(Guid.NewGuid(), "Paco", "Caniche", 14),
            };

            animalManager.Animals = animals;
            Dictionary<string, object> animalsReflecion = animalManager.DecodeObject();
            var anonimousObj = new { animals.First().Name, animals.First().Age };

            foreach (var property in animalsReflecion)
            {
                Console.ForegroundColor = property.Value is string ? ConsoleColor.Red : ConsoleColor.Yellow;
                Console.WriteLine($"{property.Key}: {property.Value}");
            }

        }

    }
}
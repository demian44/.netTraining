using System;
using Entities.Animals.Interfaces;

namespace Entities.Animlas
{
    public class Dog : IAnimal
    {
        /// <summary>
        /// Initializes a new instance of the Dog class
        /// </summary>
        public Dog()
        {
        }

        public Dog(Guid id, string race, string name, int age, Guid? managerId = null)
        {
            this.Id = id;
            this.Race = race;
            this.Name = name;
            this.Age = age;
            this.ManagerId = managerId ?? Guid.Empty;
        }

        public Guid Id { get; set; }

        public Guid ManagerId { get; set; }

        public string Race { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
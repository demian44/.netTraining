using Entities.Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Entities
{
    public class AnimalManager<TAnimal>
        where TAnimal : IAnimal,
        new()
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<IAnimal> Animals { get; set; }

        public Dictionary<string, object> DecodeObject()
        {
            var element = this.Animals.FirstOrDefault();
            var properties = new Dictionary<string, object>();

            try
            {
                var objectType = element.GetType();
                foreach (var property in objectType.GetProperties())
                {
                    properties.Add(property.Name, property.GetValue(element));
                }
            }
            catch
            {
                throw;
            }

            return properties;
        }
    }
}

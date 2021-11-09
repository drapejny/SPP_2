using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Faker.Generators;

namespace UShortGeneratorPlugin
{
    public class UShortGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(ushort));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            return (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Faker.Generators;

namespace SByteGeneratorPlugin
{
    public class SByteGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(sbyte));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            return (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        }
    }
}

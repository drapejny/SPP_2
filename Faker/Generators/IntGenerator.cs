using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class IntGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(int));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            return new Random().Next(int.MinValue, int.MaxValue);
        }
    }
}

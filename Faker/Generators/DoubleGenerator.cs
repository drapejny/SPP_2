using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class DoubleGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(double));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            return new Random().NextDouble();
        }
    }
}

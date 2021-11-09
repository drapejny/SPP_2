using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class DoubleGenerator : IGenerator
    {
        public object Generate()
        {
            return new Random().NextDouble();
        }

        public Type GeneratorType()
        {
            return typeof(double);
        }
    }
}

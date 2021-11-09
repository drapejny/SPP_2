using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class FloatGenerator : IGenerator
    {
        public object Generate()
        {
            return (float)(new Random().NextDouble());
        }

        public Type GeneratorType()
        {
            return typeof(float);
        }
    }
}

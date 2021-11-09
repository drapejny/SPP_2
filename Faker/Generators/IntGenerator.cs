using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class IntGenerator : IGenerator
    {
        public object Generate()
        {
            return new Random().Next(int.MinValue, int.MaxValue);
        }

        public Type GeneratorType()
        {
            return typeof(int);
        }
    }
}

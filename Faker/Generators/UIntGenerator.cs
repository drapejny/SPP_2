using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class UIntGenerator : IGenerator
    {
        public object Generate()
        {
            Random random = new Random();
            uint thirtyBits = (uint)random.Next(1 << 30);
            uint twoBits = (uint)random.Next(1 << 2);
            uint result = (thirtyBits << 2) | twoBits;
            return result;
        }

        public Type GeneratorType()
        {
            return typeof(uint);
        }
    }
}

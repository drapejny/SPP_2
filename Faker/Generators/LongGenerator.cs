using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class LongGenerator : IGenerator
    {
        public object Generate()
        {
            Random random = new Random();
            long result = random.Next(int.MinValue, int.MaxValue);
            result = result << 32;
            result |= (long)random.Next(int.MinValue, int.MaxValue);
            return result;
        }

        public Type GeneratorType()
        {
            return typeof(long);
        }
    }
}

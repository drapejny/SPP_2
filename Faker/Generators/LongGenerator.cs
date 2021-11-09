using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class LongGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(long));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            Random random = new Random();
            long result = random.Next(int.MinValue, int.MaxValue);
            result = result << 32;
            result |= (long)random.Next(int.MinValue, int.MaxValue);
            return result;
        }
    }
}

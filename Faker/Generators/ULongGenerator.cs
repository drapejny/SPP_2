using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ULongGenerator : IGenerator
    {
        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(ulong));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            uint first = faker.Create<uint>();
            uint second = faker.Create<uint>();
            ulong result = first;
            result <<= 32;
            result = result | (second);
            return result;
        }
    }
}

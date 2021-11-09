using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class StringGenerator : IGenerator
    {

        public bool CanGenerate(Type type)
        {
            return type.Equals(typeof(string));
        }

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            Random random = new Random();
            int length = random.Next(byte.MaxValue);
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                builder.Append(faker.Create<char>());
            }
            return builder.ToString();
        }
    }
}

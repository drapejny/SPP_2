using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class StringGenerator : IGenerator
    {
        private static CharGenerator charGenerator = new CharGenerator();
        public object Generate()
        {
            Random random = new Random();
            int length = random.Next(byte.MaxValue);
            StringBuilder builder = new StringBuilder();
            CharGenerator chr = new CharGenerator();
            for (int i = 0; i < length; i++)
            {
                builder.Append(charGenerator.Generate());
            }
            return builder.ToString();
        }

        public Type GeneratorType()
        {
            return typeof(string);
        }
    }
}

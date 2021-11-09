using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ShortGenerator : IGenerator
    {
        public object Generate()
        {
            return (short)(new Random().Next(short.MinValue, short.MaxValue));
        }

        public Type GeneratorType()
        {
            return typeof(short);
        }
    }
}

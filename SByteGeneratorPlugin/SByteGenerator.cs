using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Generators;

namespace SByteGeneratorPlugin
{
    public class SByteGenerator : IGenerator
    {
        public object Generate()
        {
            return (sbyte)(new Random().Next(sbyte.MinValue, sbyte.MaxValue));
        }

        public Type GeneratorType()
        {
            return typeof(sbyte);
        }
    }
}

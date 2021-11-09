using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Generators;

namespace UShortGeneratorPlugin
{
    public class UShortGenerator : IGenerator
    {
        public object Generate()
        {
            return (ushort)(new Random().Next(ushort.MinValue, ushort.MaxValue));
        }

        public Type GeneratorType()
        {
            return typeof(uint);
        }
    }
}

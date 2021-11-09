using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ULongGenerator : IGenerator
    {
        public object Generate()
        {
            UIntGenerator uIntGenerator = new UIntGenerator();
            uint first = (uint) uIntGenerator.Generate();
            uint second = (uint)uIntGenerator.Generate();
            ulong result = (ulong)first;
            result <<= 32;
            result = result | ((ulong)second);
            return result;
        }

        public Type GeneratorType()
        {
            return typeof(ulong);
        }
    }
}

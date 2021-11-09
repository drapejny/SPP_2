using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class CharGenerator : IGenerator
    {
        public object Generate()
        {
            return (char)(new Random().Next(32, 126));
        }

        public Type GeneratorType()
        {
            return typeof(char);
        }   
    }
}

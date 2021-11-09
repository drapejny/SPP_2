using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ArrayGenerator : IGenerator
    {

        public object Generate(Type type, IFaker faker)
        {
            if (!CanGenerate(type))
            {
                throw new ArgumentException("Bad type of the argument");
            }
            var elementType = type.GetElementType();
            int length = new Random().Next(0, 10);
            var result = Array.CreateInstance(elementType, length);
            for (int i = 0; i < length; i++)
            {
                var item = faker.Create(elementType);
                result.SetValue(item, i);
            }
            return result;
        }

        public bool CanGenerate(Type type)
        {
            return type.IsArray;
        }
    }
}

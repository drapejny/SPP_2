using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ArrayGenerator : IGenerator
    {

        private IFaker faker;
        private Type arrayType;

        public ArrayGenerator(IFaker faker, Type arrayType)
        {
            this.faker = faker;
            this.arrayType = arrayType;
        }

        public object Generate()
        {
            var elementType = arrayType.GetElementType();
            if (elementType == null)
                return null;
            int length = new Random().Next(0, 9);
            var result = Array.CreateInstance(elementType, length);
            for (int i = 0; i < length; i++)
            {
                var item = faker.Create(elementType);
                result.SetValue(item, i);
            }
            return result;
        }

        public Type GeneratorType()
        {
            return typeof(Array);
        }
    }
}

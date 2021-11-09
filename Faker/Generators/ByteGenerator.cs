﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ByteGenerator : IGenerator
    {
        public object Generate()
        {
            return (byte) (new Random().Next(byte.MinValue, byte.MaxValue));
        }

        public Type GeneratorType()
        {
            return typeof(byte);
        }
    }
}

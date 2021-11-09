using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class DateGenerator : IGenerator
    {
        public object Generate()
        {
            Random random = new Random();
            DateTime start = new DateTime(2000, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        public Type GeneratorType()
        {
            return typeof(DateTime);    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public interface IFaker
    {
        public T Create<T>()
        {
            return (T)(Create(typeof(T)));
        }

        public object Create(Type type);
    }
}

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker.Generators;

namespace Faker
{
    public class Faker : IFaker
    {
        private readonly List<IGenerator> generators;
        private readonly List<Type> circularReferencesEncounter;

        public Faker()
        {
            circularReferencesEncounter = new List<Type>(); 
            generators = new List<IGenerator>
        {
            {new ArrayGenerator()},
            {new BoolGenerator()},
            {new ByteGenerator()},
            {new CharGenerator()},
            {new DateGenerator()},
            {new DoubleGenerator()},
            {new FloatGenerator()},
            {new IntGenerator()},
            {new LongGenerator()},
            {new ShortGenerator()},
            {new StringGenerator()},
            {new UIntGenerator()},
            {new ULongGenerator()}
        };
            PluginLoader pluginLoader = new PluginLoader();
            pluginLoader.LoadPluginGenerators(generators);
        }

        public T Create<T>()
        {
            return (T)(Create(typeof(T)));
        }

        public object Create(Type type)
        {
            object instance;

            if (TryGenerateAbstract(type, out instance))
                return instance;

            if (TryGenerateKnown(type, out instance))
                return instance;

            if (TryGenerateEnum(type, out instance))
                return instance;

            if (TryGenerateCls(type, out instance))
                return instance;

            return default;
        }

        private bool TryGenerateAbstract(Type type, out object instance)
        {
            instance = default;
            if (type.IsAbstract)
            {
                return true;
            }
            return false;
        }

        private bool TryGenerateKnown(Type type, out object instance)
        {
            instance = null;
            IGenerator generator = generators.Find(gen => gen.CanGenerate(type));
            if (generator != null)
            {
                instance = generator.Generate(type, this);
                return true;
            }
            return false;
        }

        private bool TryGenerateEnum(Type type, out object instance)
        {
            instance = null;
            if (type.IsEnum)
            {
                Array values = type.GetEnumValues();
                Random random = new Random();
                instance = values.GetValue(random.Next(0, values.Length));
                return true;
            }
            return false;
        }

        private bool TryGenerateCls(Type type, out object instance)
        {
            instance = null;
            if (!type.IsClass && !type.IsValueType)
            {
                return false;
            }
            if (circularReferencesEncounter.Contains(type))
            {
                instance = default;
                return true;
            }
            circularReferencesEncounter.Add(type);
            if (TryConstruct(type, out instance))
            {
                FillProps(instance, type);
                FillFields(instance, type);
                circularReferencesEncounter.Remove(type);
                return true;
            }

            return false;
        }

        private bool TryConstruct(Type type, out object instance)
        {
            instance = null;
            if (TryGetMaxParamsConstructor(type, out ConstructorInfo ctn))
            {
                var prms = GenerateConstructorParams(ctn);
                instance = ctn.Invoke(prms);
                return true;
            }
            return false;
        }

        private bool TryGetMaxParamsConstructor(Type type, out ConstructorInfo ctn)
        {
            ctn = null;
            var ctns = type.GetConstructors();

            if (ctns.Length == 0)
            {
                return false;
            }
            foreach (var locCtn in ctns)
            {
                if (locCtn.IsPublic &&
                    (ctn == null || locCtn.GetParameters().Length > ctn.GetParameters().Length))
                {
                    ctn = locCtn;
                }
            }
            if (ctn == null)
            {
                return false;
            }
            return true;
        }

        private void FillProps(object instance, Type type)
        {
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                if (!prop.CanWrite)
                    continue;
                if (prop.GetSetMethod() == null)
                    continue;
                prop.SetValue(instance, Create(prop.PropertyType));
            }
        }

        private void FillFields(object instance, Type type)
        {
            var fields = type.GetFields();

            foreach (var field in fields)
            {
                if (!field.IsPublic)
                    continue;

                field.SetValue(instance, Create(field.FieldType));
            }
        }

        private object[] GenerateConstructorParams(ConstructorInfo constructor)
        {
            var prms = constructor.GetParameters();
            object[] generated = new object[prms.Length];
            for (int i = 0; i < prms.Length; i++)
            {
                var p = prms[i];
                generated[i] = Create(p.ParameterType);
            }
            return generated;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Faker.Generators;

namespace Faker
{
   public class PluginLoader
    {
        private static readonly string PluginPath = Path.Combine("D:\\VS Projects\\SPP_2\\Faker", "plugins");

        public PluginLoader()
        {
        }

        public void LoadPluginGenerators(List<IGenerator> generators)
        {
            if (!Directory.Exists(PluginPath)) {
                return;
            }
            string[] fileNames = Directory.GetFiles(PluginPath, "*.dll");
            foreach (var fileName in fileNames)
            {
                Assembly assembly = Assembly.LoadFrom(fileName);
                LoadPluginGenerator(assembly,generators);
            }
        }

        private void LoadPluginGenerator(Assembly plugin, List<IGenerator> generators)
        {
            Type generatorType = plugin.GetTypes().FirstOrDefault(type => typeof(IGenerator).IsAssignableFrom(type));
            if (generatorType == null)
                return;
            if (generatorType.FullName == null)
                return;
            if (!generatorType.IsClass)
                return;
            if (plugin.CreateInstance(generatorType.FullName) is IGenerator generator)
            {
                generators.Add(generator);
            }
        }
    }
}

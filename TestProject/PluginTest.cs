using NUnit.Framework;
using Faker.Generators;
using Faker;
using System.Collections.Generic;

namespace TestProject
{

    class PluginTest
    {
        [Test]
        public void PluginLoadTest()
        {
            List<IGenerator> generators = new List<IGenerator>();
            PluginLoader pluginLoader = new PluginLoader();
            pluginLoader.LoadPluginGenerators(generators);
            Assert.AreEqual(generators.Count, 2);
        }

        [Test]
        public void FirstPluginGeneratorTest()
        {
            Faker.Faker faker = new Faker.Faker();
            object sbyteObject = faker.Create<sbyte>();
            Assert.AreEqual(sbyteObject.GetType(), typeof(sbyte));
        }

        [Test]
        public void SecondPluginGeneratorTest()
        {
            Faker.Faker faker = new Faker.Faker();
            object ushortObject = faker.Create<ushort>();
            Assert.AreEqual(ushortObject.GetType(), typeof(ushort));
        }
    }
}

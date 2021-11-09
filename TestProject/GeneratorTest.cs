using NUnit.Framework;
using Faker.Generators;
using Faker;
using System; 
using System.Collections.Generic;

namespace TestProject
{
    class GeneratorTest
    {

        private static Faker.Faker faker = new Faker.Faker();

        [Test]
        public void ArrayGeneratorTest()
        {
            object o = new ArrayGenerator().Generate(typeof(int[]), faker);
            Assert.AreEqual(o.GetType(), typeof(int[]));
        }
        [Test]
        public void ArrayGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ArrayGenerator().Generate(typeof(bool), faker));
        }
        [Test]
        public void BoolGeneratorTest()
        {
            object o = new BoolGenerator().Generate(typeof(bool), faker);
            Assert.AreEqual(o.GetType(), typeof(bool));
        }
        [Test]
        public void BoolGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new BoolGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void ByteGeneratorTest()
        {
            object o = new ByteGenerator().Generate(typeof(byte), faker);
            Assert.AreEqual(o.GetType(), typeof(byte));
        }
        [Test]
        public void ByteGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ByteGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void CharGeneratorTest()
        {
            object o = new CharGenerator().Generate(typeof(char), faker);
            Assert.AreEqual(o.GetType(), typeof(char));
        }
        [Test]
        public void CharGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new CharGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void DateGeneratorTest()
        {
            object o = new DateGenerator().Generate(typeof(DateTime), faker);
            Assert.AreEqual(o.GetType(), typeof(DateTime));
        }
        [Test]
        public void DateGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new DateGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void DoubleGeneratorTest()
        {
            object o = new DoubleGenerator().Generate(typeof(double), faker);
            Assert.AreEqual(o.GetType(), typeof(double));
        }
        [Test]
        public void DoubleGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new DoubleGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void FloatGeneratorTest()
        {
            object o = new FloatGenerator().Generate(typeof(float), faker);
            Assert.AreEqual(o.GetType(), typeof(float));
        }
        [Test]
        public void FloatGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new FloatGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void IntGeneratorTest()
        {
            object o = new IntGenerator().Generate(typeof(int), faker);
            Assert.AreEqual(o.GetType(), typeof(int));
        }
        [Test]
        public void IntGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ByteGenerator().Generate(typeof(bool), faker));
        }
        [Test]
        public void LongGeneratorTest()
        {
            object o = new LongGenerator().Generate(typeof(long), faker);
            Assert.AreEqual(o.GetType(), typeof(long));
        }
        [Test]
        public void LongGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ByteGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void ShortGeneratorTest()
        {
            object o = new ShortGenerator().Generate(typeof(short), faker);
            Assert.AreEqual(o.GetType(), typeof(short));
        }
        [Test]
        public void ShortGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ShortGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void StringGeneratorTest()
        {
            object o = new StringGenerator().Generate(typeof(string), faker);
            Assert.AreEqual(o.GetType(), typeof(string));
        }
        [Test]
        public void StringGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new StringGenerator().Generate(typeof(int), faker));
        }
        [Test]
        public void UIntGeneratorTest()
        {
            object o = new UIntGenerator().Generate(typeof(uint), faker);
            Assert.AreEqual(o.GetType(), typeof(uint));
        }
        [Test]
        public void UIntGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new UIntGenerator().Generate(typeof(bool), faker));
        }
        [Test]
        public void ULongGeneratorTest()
        {
            object o = new ULongGenerator().Generate(typeof(ulong), faker);
            Assert.AreEqual(o.GetType(), typeof(ulong));
        }
        [Test]
        public void ULongGeneratorExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => new ULongGenerator().Generate(typeof(bool), faker));
        }
    }
}

using NUnit.Framework;
using Faker.Generators;
using Faker;
using System;
using System.Collections.Generic;

namespace TestProject
{
    class FakerTest
    {
        [Test]
        public void NoConstructorClassTest()
        {
            Faker.Faker faker = new Faker.Faker();
            A a = faker.Create<A>();
            bool result = a.a != default(int) && a.b != default(double) && a.c != default(string);
            Assert.IsTrue(result);
        }
        [Test]
        public void SeveralConstructorsClassTest()
        {
            Faker.Faker faker = new Faker.Faker();
            B b = faker.Create<B>();
            bool result = b.a != default(int) && b.b != default(double) && b.c != default(string);
            Assert.IsTrue(result);
        }
        [Test]
        public void PrivateConstructorClassTest()
        {
            Faker.Faker faker = new Faker.Faker();
            C c = faker.Create<C>();
            Assert.IsNull(c);
        }
        [Test]
        public void CircleReferencesTest()
        {
            Faker.Faker faker = new Faker.Faker();
            D d = faker.Create<D>();
            Assert.IsNull(d.e.d);
        }
        [Test]
        public void ArrayTypeTest()
        {
            Faker.Faker faker = new Faker.Faker();
            F f = faker.Create<F>();
            bool result = f.array.Length != 0 && f.matrix.Length != 0;
            Assert.IsTrue(result);
        }
        private class A
        {
            public int a;
            public double b;
            public string c;
        }

        private class B
        {
            public int a;
            public double b;
            public string c;

            public B()
            {

            }

            public B(int a)
            {
                this.a = a;
            }

            public B(int a, string c)
            {
                this.a = a;
                this.c = c;
            }
        }
        private class C
        {
            public int a;
            public double b;
            public string c;

            private C() { }
        }

        private class D
        {
            public E e;
        }

        private class E
        {
            public D d;
        }

        private class F
        {
           public int[] array;
           public int[][] matrix;
        }
    }
}

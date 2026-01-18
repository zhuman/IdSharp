using IdSharp.Common.Events;
using NUnit.Framework;

namespace IdSharp.Common.Tests.Events
{
    [TestFixture]
    public class DataEventArgsTest
    {
        [Test]
        public void TestConstructorAndDataProperty_Null()
        {
            DataEventArgs<string> dea = new DataEventArgs<string>(null);
            Assert.That(dea.Data, Is.Null);
        }

        [Test]
        public void TestConstructorAndDataProperty_NotNull()
        {
            DataEventArgs<int> dea = new DataEventArgs<int>(42);
            Assert.That(dea.Data, Is.EqualTo(42));
        }

        [Test]
        public void TestSetData_Null()
        {
            var dea = new DataEventArgs<string>("Hello");
            Assert.That(dea.Data, Is.EqualTo("Hello"));
            dea.Data = null;
            Assert.That(dea.Data, Is.Null);
        }

        [Test]
        public void TestSetData_NotNull()
        {
            var dea = new DataEventArgs<string>("Hello");
            Assert.That(dea.Data, Is.EqualTo("Hello"));
            dea.Data = "World";
            Assert.That(dea.Data, Is.EqualTo("World"));
        }
    }
}

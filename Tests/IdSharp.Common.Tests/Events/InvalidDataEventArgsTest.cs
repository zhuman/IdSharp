using IdSharp.Common.Events;
using NUnit.Framework;

namespace IdSharp.Common.Tests.Events
{
    [TestFixture]
    public class InvalidDataEventArgsTest
    {
        [Test]
        public void Test_Ctors()
        {
            var x = new InvalidDataEventArgs("propertyName", "message");
            Assert.That(x.Property, Is.EqualTo("propertyName"));
            Assert.That(x.Message, Is.EqualTo("message"));
            Assert.That(x.ErrorType, Is.EqualTo(ErrorType.Warning));

            x = new InvalidDataEventArgs("propertyName2", "message", ErrorType.Error);
            Assert.That(x.Property, Is.EqualTo("propertyName2"));
            Assert.That(x.Message, Is.EqualTo("message"));
            Assert.That(x.ErrorType, Is.EqualTo(ErrorType.Error));

            x = new InvalidDataEventArgs("propertyName3", ErrorType.None);
            Assert.That(x.Property, Is.EqualTo("propertyName3"));
            Assert.That(string.IsNullOrEmpty(x.Message), Is.True);
            Assert.That(x.ErrorType, Is.EqualTo(ErrorType.None));
        }
    }
}

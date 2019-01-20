using System.Collections;
using CalculatorState.Calculator;
using NUnit.Framework;

namespace CalculatorStateTest
{
    [TestFixture]
    class ContextTest
    {
        [Test]
        public void run()
        {
            Context context = new Context();
            Assert.That(0, Is.EqualTo(0));
            Assert.That(context.run("C"), Is.EqualTo(0));
            Assert.That(context.run("C3"), Is.EqualTo(3));
            Assert.That(context.run("C25"), Is.EqualTo(25));
            Assert.That(context.run("C257452"), Is.EqualTo(257452));
            Assert.That(context.run("C257452="), Is.EqualTo(257452));
            Assert.That(context.run("C2+3="), Is.EqualTo(5));
            Assert.That(context.run("C123+654="), Is.EqualTo(777));
            Assert.That(context.run("C2+2*2="), Is.EqualTo(8));
            Assert.That(context.run("C5+="), Is.EqualTo(10));
            Assert.That(context.run("C125-25="), Is.EqualTo(100));
            Assert.That(context.run("C100/5="), Is.EqualTo(20));
            Assert.That(context.run("C7*8="), Is.EqualTo(56));
            Assert.That(context.run("C45*45="), Is.EqualTo(2025));
            Assert.That(context.run("C75*75="), Is.EqualTo(5625));
            Assert.That(context.run("C9/5="), Is.EqualTo(1));
            Assert.That(context.run("C45+--/+5="), Is.EqualTo(50));
            Assert.That(context.run("C45-7*3/2="), Is.EqualTo(57));
            Assert.That(context.run("C5+15=30="), Is.EqualTo(45));
        }
    }
}

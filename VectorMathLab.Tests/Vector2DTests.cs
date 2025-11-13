using VectorMathLab.Implementation;

namespace VectorMathLab.Tests
{
    [TestFixture]
    public class Vector2DTests
    {
        [Test]
        public void Abs_ShouldReturnCorrectLength()
        {
            var v = new Vector2D(3, 4);
            Assert.That(v.Abs(), Is.EqualTo(5).Within(0.001));
        }

        [Test]
        public void Cdot_ShouldReturnCorrectDotProduct()
        {
            var v1 = new Vector2D(1, 2);
            var v2 = new Vector2D(3, 4);
            var result = v1.Cdot(v2);
            Assert.That(result, Is.EqualTo(11)); // 1*3 + 2*4 = 11
        }

        [Test]
        public void GetComponents_ShouldReturnCorrectArray()
        {
            var v = new Vector2D(-2, 7);
            var comps = v.GetComponents();
            Assert.That(comps, Is.EqualTo(new double[] { -2, 7 }));
        }
    }
}
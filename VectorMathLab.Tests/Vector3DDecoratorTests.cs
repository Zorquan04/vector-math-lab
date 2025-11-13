using VectorMathLab.Implementation;

namespace VectorMathLab.Tests
{
    [TestFixture]
    public class Vector3DDecoratorTests
    {
        [Test]
        public void Abs_ShouldReturnCorrect3DLength()
        {
            var v2D = new Vector2D(3, 4);
            var v3D = new Vector3DDecorator(v2D, 12);
            Assert.That(v3D.Abs(), Is.EqualTo(13).Within(0.001)); // √(3²+4²+12²)
        }

        [Test]
        public void Cdot_ShouldReturnCorrectResult()
        {
            var v1 = new Vector3DDecorator(new Vector2D(1, 2), 3);
            var v2 = new Vector3DDecorator(new Vector2D(4, -1), 2);
            Assert.That(v1.Cdot(v2), Is.EqualTo(1*4 + 2*(-1) + 3*2)); // = 10
        }

        [Test]
        public void Cross_ShouldReturnCorrect3DVector()
        {
            var v1 = new Vector3DDecorator(new Vector2D(1, 0), 0);
            var v2 = new Vector3DDecorator(new Vector2D(0, 1), 0);
            var result = v1.Cross(v2);
            Assert.That(result.X, Is.EqualTo(0));
            Assert.That(result.Y, Is.EqualTo(0));
            Assert.That(result.Z, Is.EqualTo(1)); // standardowy wynik e1 × e2 = e3
        }
    }
}
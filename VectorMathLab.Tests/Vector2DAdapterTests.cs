using VectorMathLab.Implementation;

namespace VectorMathLab.Tests
{
    [TestFixture]
    public class Polar2DAdapterTests
    {
        [Test]
        public void GetAngle_ShouldReturnCorrectAngle()
        {
            var v = new Vector2D(1, Math.Sqrt(3)); // 60° -> π/3
            var polar = new Polar2DAdapter(v);
            Assert.That(polar.GetAngle(), Is.EqualTo(Math.PI / 3).Within(0.001));
        }

        [Test]
        public void Abs_ShouldMatchOriginalVector()
        {
            var v = new Vector2D(3, 4);
            var polar = new Polar2DAdapter(v);
            Assert.That(polar.Abs(), Is.EqualTo(v.Abs()).Within(0.001));
        }
    }
}
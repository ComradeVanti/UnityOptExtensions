using ComradeVanti.CSharpTools;
using NUnit.Framework;
using UnityEngine;

namespace Dev.ComradeVanti
{

    [TestFixture]
    public class OptFromUnityObjectTests
    {

        [Test]
        public void OptsCreatedFromNullObjectsAreNone() =>
            Assert.That(((Object)null).ToOpt().IsNone());

        [Test]
        public void OptsCreatedFromNonNullObjectsAreSome()
        {
            var obj = new Texture2D(0, 0);
            Assert.That(obj.ToOpt().IsSome());
        }

        [Test]
        public void OptsCreatedFromDestroyedObjectsAreNone()
        {
            var obj = new Texture2D(0, 0);
            Object.DestroyImmediate(obj);

            Assert.That(obj.ToOpt().IsNone());
        }

    }

}
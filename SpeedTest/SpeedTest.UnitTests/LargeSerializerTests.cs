using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SpeedTest.TestObjects;

namespace SpeedTest.UnitTests
{
    [TestClass]
    public class LargeSerializerTests
    {
        [TestMethod]
        public void LargeSerializationFromNewtonsoftShouldWork()
        {
            var result = new LargeSerializers.LargeNewtonSoftWrapperSerializer().TestableAct();

            var deserializedResult = JsonConvert.DeserializeObject<LargeTestObject>(result);

            deserializedResult.ShouldBeEquivalentTo(UniformTestObjects.LargeObject);
        }

        [TestMethod]
        public void LargeDesializationFromNewtonsoft()
        {
            var result = new LargeDeserializers.LargeNewtonSoftWrapperDeserializer().TestableAct();

            result.ShouldBeEquivalentTo(UniformTestObjects.LargeObject);
        }

        [TestMethod]
        public void LargeBondSerializer()
        {
            var result = new LargeSerializers.LargeBondSerializer().TestableAct();

            result.Should().BeOfType<string>();
        }
    }
}

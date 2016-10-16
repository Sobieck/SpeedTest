using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SpeedTest.SmallDeserializers;
using SpeedTest.SmallSerializers;
using SpeedTest.TestObjects;

namespace SpeedTest.UnitTests
{
    [TestClass]
    public class SmallSerializerTests
    {
        [TestMethod]
        public void TheSerializerShouldOutputAStringThatCanBeDeserialedInAValidObject()
        {
            var result = new SmallNewtonSoftWrapperSerializer().TestableAct();

            var deserializedObject = JsonConvert.DeserializeObject<SmallTestObject>(result);

            deserializedObject.ShouldBeEquivalentTo(UniformTestObjects.SmallObject);
        }

        [TestMethod]
        public void TheDeserializerShouldOutputAnObject()
        {
            var result = new SmallNewtonSoftWrapperDeserializer().TestableAct();

            result.ShouldBeEquivalentTo(UniformTestObjects.SmallObject);
        }

        [TestMethod]
        public void TheUnwrapperDeserializerShouldOutputAnObject()
        {
            var result = new SmallNewtonSoftStreamDeserializer().TestableAct();

            result.ShouldBeEquivalentTo(UniformTestObjects.SmallObject);
        }

        [TestMethod]
        public void TheManualMappDeserializerShouldOutputAnObject()
        {
            var result = new SmallNewtonSoftManualMapDeserializer().TestableAct();

            result.ShouldBeEquivalentTo(UniformTestObjects.SmallObject);
        }

        [TestMethod]
        public void BondShouldWorkAtSerialization()
        {
            var result = new SmallBondSerializer().TestableAct();
            result.Should().BeOfType<string>();

            var expect = UniformTestObjects.SmallObject;
            var deserialized = new SmallBondDeserializer().TestableAct();
            deserialized.ShouldBeEquivalentTo(expect);            
        }
    }
}

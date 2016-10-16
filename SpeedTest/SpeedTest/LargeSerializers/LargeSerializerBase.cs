using SnippetSpeed;
using SpeedTest.TestObjects;

namespace SpeedTest.LargeSerializers
{
    public abstract class LargeSerializerBase : TestableSnippetSpeedBase<string>
    {
        public override string TypeOfTest => "Large Object Serializer";

        public LargeTestObject testObject => UniformTestObjects.LargeObject;
    }
}

using SnippetSpeed;
using SpeedTest.TestObjects;

namespace SpeedTest
{
    public abstract class SmallObjectSerializerBase : TestableSnippetSpeedBase<string>
    {
        public override string TypeOfTest => "Small Object Serializer";

        public SmallTestObject smallObject => UniformTestObjects.SmallObject;
    }
}

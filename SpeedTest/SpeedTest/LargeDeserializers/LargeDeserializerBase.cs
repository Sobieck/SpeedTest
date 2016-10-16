using SnippetSpeed;
using SpeedTest.TestObjects;

namespace SpeedTest.LargeDeserializers
{
    public abstract class LargeDeserializerBase : TestableSnippetSpeedBase<LargeTestObject>
    {
        public override string TypeOfTest => "Large Object Serializer";
    }
}

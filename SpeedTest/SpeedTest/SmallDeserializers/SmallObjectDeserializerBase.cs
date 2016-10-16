using SnippetSpeed;
using SpeedTest.TestObjects;

namespace SpeedTest.SmallDeserializers
{
    public abstract class SmallObjectDeserializerBase : TestableSnippetSpeedBase<SmallTestObject>
    {
        public override string TypeOfTest => "Small Object Deserializer";
    }
}

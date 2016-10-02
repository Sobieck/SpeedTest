using SpeedTest.AbstractClasses;

namespace SpeedTest.SmallObjectSerialization
{
    public abstract class SmallObjectSerializationBase : SmallObjectBase
    {
        public override string TypeOfTest { get { return TypesOfTest.SmallObjectSerialization; } }
    }
}

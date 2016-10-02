using SpeedTest.TestObjects;

namespace SpeedTest.AbstractClasses
{
    public abstract class SmallObjectBase : Base
    {
        public SmallObjectBase()
        {
            testObject = UniformTestObjects.SmallObject;
        }

        protected TestObject2 testObject { get; private set; }
    }
}

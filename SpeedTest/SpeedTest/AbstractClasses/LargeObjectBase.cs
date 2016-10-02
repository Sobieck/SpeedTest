using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest.AbstractClasses
{
    public abstract class LargeObjectBase : Base
    {
        public LargeObjectBase()
        {
            testObject = RandomValue.Object<TestObject>();
        }

        protected TestObject testObject { get; private set; }
    }
}

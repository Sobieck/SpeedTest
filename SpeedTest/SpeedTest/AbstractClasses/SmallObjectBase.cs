using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest.AbstractClasses
{
    public abstract class SmallObjectBase : Base
    {
        public SmallObjectBase()
        {
            testObject = RandomValue.Object<TestObject2>();
        }

        protected TestObject2 testObject { get; private set; }
    }
}

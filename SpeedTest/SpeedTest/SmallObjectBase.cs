using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest
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

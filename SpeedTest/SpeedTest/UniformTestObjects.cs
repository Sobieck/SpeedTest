using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest
{
    public static class UniformTestObjects
    {
        static UniformTestObjects()
        {
            SmallObject = RandomValue.Object<SmallTestObject>();
            LargeObject = RandomValue.Object<TestObject>();
        }

        public static TestObject LargeObject { get; private set; }
        public static SmallTestObject SmallObject { get; private set; }
    }
}

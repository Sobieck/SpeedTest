using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest
{
    public static class UniformTestObjects
    {
        static UniformTestObjects()
        {
            SmallObject = RandomValue.Object<TestObject2>();
            LargeObject = RandomValue.Object<TestObject>();
        }

        public static TestObject LargeObject { get; private set; }
        public static TestObject2 SmallObject { get; private set; }
    }
}

using RandomTestValues;
using SpeedTest.TestObjects;

namespace SpeedTest
{
    public static class UniformTestObjects
    {
        static UniformTestObjects()
        {
            SmallObject = RandomValue.Object<SmallTestObject>();
            LargeObject = RandomValue.Object<LargeTestObject>();
        }

        public static LargeTestObject LargeObject { get; private set; }
        public static SmallTestObject SmallObject { get; private set; }
    }
}

using RandomTestValues;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest
{
    public static class UniformTestObjects
    {
        static UniformTestObjects()
        {
            SmallObject = RandomValue.Object<Employee>();
            LargeObject = RandomValue.Object<TestObject>();
        }

        public static TestObject LargeObject { get; private set; }
        public static Employee SmallObject { get; private set; }
    }
}

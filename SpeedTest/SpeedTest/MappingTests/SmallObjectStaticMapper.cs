using RandomTestValues;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.MappingTests
{
    public class SmallObjectStaticMapper : Base
    {
        private TestObject2 testObject;

        public SmallObjectStaticMapper()
        {
            testObject = RandomValue.Object<TestObject2>();
        }

        public override void Act()
        {
            var result = testObject.ToDto();
        }
    }

    public static class Mappers
    {
        public static TestObject2Dto ToDto(this TestObject2 source)
        {
            return new TestObject2Dto
            {
                RInt2 = source.RInt2,
                RString2 = source.RString2,
                RDecimal2 = source.RDecimal2,
                RDouble2 = source.RDouble2
            };
        }
    }
}

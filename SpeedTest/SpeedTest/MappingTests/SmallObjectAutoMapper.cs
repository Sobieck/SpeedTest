using AutoMapper;
using RandomTestValues;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest
{
    public class SmallObjectAutoMapper : Base
    {
        private TestObject2 testObject;

        public SmallObjectAutoMapper()
        {
            Mapper.Initialize(x => x.CreateMap<TestObject2, TestObject2Dto>());
            testObject = RandomValue.Object<TestObject2>();

        }

        public override void Act()
        {
            var result = Mapper.Map<TestObject2, TestObject2Dto>(testObject);
        }
    }
}
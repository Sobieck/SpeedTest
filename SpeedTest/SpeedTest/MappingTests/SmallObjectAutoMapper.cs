using AutoMapper;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.MappingTests
{
    public class SmallObjectAutoMapper : SmallObjectBase
    {
        public SmallObjectAutoMapper()
        {
            Mapper.Initialize(x => x.CreateMap<TestObject2, TestObject2Dto>());
        }

        public override void Act()
        {
            var result = Mapper.Map<TestObject2, TestObject2Dto>(testObject);
        }
    }
}
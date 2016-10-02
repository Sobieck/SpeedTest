using AutoMapper;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.LargeObjectMapping
{
    public class LargeObjectAutoMapper : LargeObjectMappingBase
    {
        public LargeObjectAutoMapper()
        {
            Mapper.Initialize(x => x.CreateMap<TestObject, TestObjectDto>());
        }
        
        public override void Act()
        {
            var mappedObject = Mapper.Map<TestObject, TestObjectDto>(testObject);
        }
    }
}

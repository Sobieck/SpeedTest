using AutoMapper;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;
using SpeedTest.Interfaces;

namespace SpeedTest.LargeObjectMapping
{
    public class LargeObjectAutoMapper : LargeObjectMappingBase
    {

        public LargeObjectAutoMapper()
        {
            Mapper.Initialize(x => x.AddProfile<ProfileForAutoMapper>());
        }

        public override ILargeObject TestableAct()
        {
            return Mapper.Map<TestObject, TestObjectDto>(testObject);
        }
    }
}

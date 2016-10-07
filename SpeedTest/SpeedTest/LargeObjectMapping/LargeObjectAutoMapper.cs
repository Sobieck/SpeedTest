using AutoMapper;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;
using SpeedTest.AbstractClasses;
using SpeedTest.Interfaces;

namespace SpeedTest.LargeObjectMapping
{
    public class LargeObjectAutoMapper : TestableSpeedTestBase<ILargeObject>   
    {

        public LargeObjectAutoMapper()
        {
            Mapper.Initialize(x => x.AddProfile<ProfileForAutoMapper>());
        }

        public override string TypeOfTest => "Large Mappers";

        public override ILargeObject TestableAct()
        {
            return Mapper.Map<TestObject, TestObjectDto>(new TestObject());
        }
    }
}

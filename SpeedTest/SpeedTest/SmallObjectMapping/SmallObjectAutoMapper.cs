using AutoMapper;
using SpeedTest.Interfaces;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.SmallObjectMapping
{
    public class SmallObjectAutoMapper : SmallObjectMappingBase
    {
        public SmallObjectAutoMapper()
        {
            Mapper.Initialize(x => x.CreateMap<Employee, EmployeeDto>());
        }

        public override IEmployee TestableAct()
        {
            return Mapper.Map<Employee, EmployeeDto>(testObject);
        }
    }
}
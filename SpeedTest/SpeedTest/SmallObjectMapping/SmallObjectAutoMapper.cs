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
            Mapper.Initialize(x => x.AddProfile<ProfileForAutoMapper>());
        }

        public override T Act<T>()
        {
            return Mapper.Map<Employee, EmployeeDto>(testObject);
        }
    }
}
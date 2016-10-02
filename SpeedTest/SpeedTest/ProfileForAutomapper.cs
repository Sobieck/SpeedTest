using AutoMapper;
using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest
{
    public class ProfileForAutoMapper : Profile
    {
        public ProfileForAutoMapper()
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<TestObject, TestObjectDto>();
        }
    }
}

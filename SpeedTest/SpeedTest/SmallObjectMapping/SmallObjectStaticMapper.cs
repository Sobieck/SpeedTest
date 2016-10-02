using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;
using SpeedTest.Interfaces;

namespace SpeedTest.SmallObjectMapping
{
    public class SmallObjectStaticMapper : SmallObjectMappingBase
    {
        public override IEmployee TestableAct()
        {
            return testObject.ToDto();
        }
    }

    public static class Mappers
    {
        public static EmployeeDto ToDto(this Employee source)
        {
            return new EmployeeDto
            {
                EmployeeNumber = source.EmployeeNumber,
                Name = source.Name,
                PayPerHour = source.PayPerHour,
                Position = source.Position
            };
        }
    }
}

using SpeedTest.TestObjects;
using SpeedTest.TestObjects.DTO;
using SpeedTest.Interfaces;
using System;

namespace SpeedTest.SmallObjectMapping
{
    public class SmallObjectStaticMapper : SmallObjectMappingBase
    {
        public override T Act<T>()
        {
            return (T)testObject.ToDto();
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

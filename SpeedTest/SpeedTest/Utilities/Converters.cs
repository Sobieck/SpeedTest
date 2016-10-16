using SpeedTest.BondDtos;
using SpeedTest.TestObjects;
using System;

namespace SpeedTest.Utilities
{
    public static class Converters
    {
        public static ArraySegment<byte> ConvertToArraySegment(this decimal value)
        {
            var bits = decimal.GetBits(value);
            var data = new byte[bits.Length * sizeof(int)];
            Buffer.BlockCopy(bits, 0, data, 0, data.Length);
            return new ArraySegment<byte>(data);
        }

        public static decimal ConvertToDecimal(this ArraySegment<byte> value)
        {
            var bits = new int[value.Count / sizeof(int)];
            Buffer.BlockCopy(value.Array, value.Offset, bits, 0, bits.Length * sizeof(int));
            return new decimal(bits);
        }

        public static SmallTestObjectDto ToSmallObjectDto(this SmallTestObject source)
        {
            return new SmallTestObjectDto
            {
                EmployeeNumber = source.EmployeeNumber,
                Name = source.Name,
                PayPerHour = source.PayPerHour.ConvertToArraySegment(),
                Position = source.Position
            };
        }

        public static BondDtos.TestEnum ToBondTestEnum(this TestObjects.TestEnum source)
        {
            return (BondDtos.TestEnum)(int)source;
        }
    }
}

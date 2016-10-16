using System;
using SpeedTest.TestObjects;
using Bond;
using Bond.Protocols;
using Bond.IO.Safe;
using SpeedTest.SmallSerializers;
using SpeedTest.BondDtos;
using SpeedTest.Utilities;

namespace SpeedTest.SmallDeserializers
{
    public class SmallBondDeserializer : SmallObjectDeserializerBase
    {
        private Deserializer<CompactBinaryReader<InputBuffer>> deserializer;

        public string StringToDeserialize { get; private set; }

        public SmallBondDeserializer()
        {
            deserializer = new Deserializer<CompactBinaryReader<InputBuffer>>(typeof(SmallTestObjectDto));
            StringToDeserialize = new SmallBondSerializer().TestableAct();
        }

        public override SmallTestObject TestableAct()
        {
            var bytes = Convert.FromBase64String(StringToDeserialize);
            var input = new InputBuffer(bytes);
            var reader = new CompactBinaryReader<InputBuffer>(input);

            var dto = deserializer.Deserialize<SmallTestObjectDto>(reader);

            return new SmallTestObject
            {
                EmployeeNumber = dto.EmployeeNumber,
                Name = dto.Name,
                PayPerHour = dto.PayPerHour.ConvertToDecimal(),
                Position = dto.Position
            };
        }
    }
}

using Bond;
using Bond.IO.Safe;
using Bond.Protocols;
using SpeedTest.BondDtos;
using SpeedTest.Utilities;
using System;

namespace SpeedTest.SmallSerializers
{
    public class SmallBondSerializer : SmallObjectSerializerBase
    {
        private readonly Serializer<CompactBinaryWriter<OutputBuffer>> serializer;

        public SmallBondSerializer()
        {
            serializer = new Serializer<CompactBinaryWriter<OutputBuffer>>(typeof(SmallTestObjectDto));
        }

        public override string TestableAct()
        {
            var bondObject = new SmallTestObjectDto
            {
                EmployeeNumber = smallObject.EmployeeNumber,
                Name = smallObject.Name,
                PayPerHour = smallObject.PayPerHour.ConvertToArraySegment(),
                Position = smallObject.Position
            };

            var output = new OutputBuffer(2 * 1024);
            var writer = new CompactBinaryWriter<OutputBuffer>(output);

            serializer.Serialize(bondObject, writer);

            return Convert.ToBase64String(output.Data.Array, output.Data.Offset, output.Data.Count);
        }
    }

    
}

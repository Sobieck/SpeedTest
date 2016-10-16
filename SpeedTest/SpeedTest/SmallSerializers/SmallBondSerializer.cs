using Bond;
using Bond.IO.Safe;
using Bond.Protocols;
using SpeedTest;
using System;

namespace SpeedTest.SmallSerializers
{
    public class SmallBondSerializer : SmallObjectSerializerBase
    {
        private Serializer<CompactBinaryWriter<OutputBuffer>> serializer;

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
    }
}

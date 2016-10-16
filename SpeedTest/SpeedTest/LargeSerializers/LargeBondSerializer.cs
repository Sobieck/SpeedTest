using Bond;
using Bond.IO.Safe;
using Bond.Protocols;
using SpeedTest.BondDtos;
using SpeedTest.Utilities;
using System;
using System.Linq;

namespace SpeedTest.LargeSerializers
{
    public class LargeBondSerializer : LargeSerializerBase
    {
        private readonly Serializer<CompactBinaryWriter<OutputBuffer>> serializer;

        public LargeBondSerializer()
        {
            serializer = new Serializer<CompactBinaryWriter<OutputBuffer>>(typeof(LargeTestObjectDto));
        }

        public override string TestableAct()
        {
            var bondObject = new LargeTestObjectDto
            {
                RInt = testObject.RInt,
                RString = testObject.RString,
                RDecimal = testObject.RDecimal.ConvertToArraySegment(),
                RDouble = testObject.RDouble,
                RInt2 = testObject.RInt2,
                RString2 = testObject.RString2,
                RDecimal2 = testObject.RDecimal2.ConvertToArraySegment(),
                RDouble2 = testObject.RDouble2,
                REnum = testObject.REnum.ToBondTestEnum(),
                RGuid = testObject.RGuid.ToString(),
                RDateTime = testObject.RDateTime.Ticks,
                TestObject2 = testObject.TestObject2.ToSmallObjectDto(),
                TestObject3 = testObject.TestObject3.ToSmallObjectDto(),
                REnumCollection = testObject.REnumCollection.Select(x => x.ToBondTestEnum()).ToList(),
                REnumList = testObject.REnumCollection.Select(x => x.ToBondTestEnum()).ToList(),
                RList = testObject.RList.ToList(),
                RList2 = testObject.RList2.ToList(),
                RCollection = testObject.RCollection.ToList(),
                RCollection2 = testObject.RCollection2.ToList(),
                RTestObject2List = testObject.RTestObject2List.Select(x => x.ToSmallObjectDto()).ToList(),
                RTestObject2Collection = testObject.RTestObject2List.Select(x => x.ToSmallObjectDto()).ToList(),
                LazyShorts = testObject.LazyShorts.ToList(),
                Strings = testObject.Strings.ToList(),
                RTestObject2Array = testObject.RTestObject2Array.Select(x => x.ToSmallObjectDto()).ToList(),
                CrazyBools = testObject.CrazyBools.Select(x => x.Select(y => y.ToList()).ToList()).ToList(),
                CrazySmallTestObjects = testObject.CrazySmallTestObjects.Select(x => x.Select(y => y.ToSmallObjectDto()).ToList()).ToList()
            };

            var output = new OutputBuffer(2 * 1024);
            var writer = new CompactBinaryWriter<OutputBuffer>(output);

            serializer.Serialize(bondObject, writer);

            return Convert.ToBase64String(output.Data.Array, output.Data.Offset, output.Data.Count);
        }


    }
}

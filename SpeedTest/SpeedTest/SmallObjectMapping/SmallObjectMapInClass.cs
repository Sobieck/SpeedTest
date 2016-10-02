using System;
using SpeedTest.AbstractClasses;
using SpeedTest.TestObjects.DTO;

namespace SpeedTest.SmallObjectMapping
{
    public class SmallObjectMapInClass : SmallObjectMappingBase
    {
        public override void Act()
        {
            var result = new TestObject2Dto
            {
                RInt2 = testObject.RInt2,
                RString2 = testObject.RString2,
                RDecimal2 = testObject.RDecimal2,
                RDouble2 = testObject.RDouble2
            };
        }
    }
}

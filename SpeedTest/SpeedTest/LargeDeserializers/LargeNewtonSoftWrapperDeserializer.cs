using System;
using SpeedTest.TestObjects;
using Newtonsoft.Json;

namespace SpeedTest.LargeDeserializers
{
    public class LargeNewtonSoftWrapperDeserializer : LargeDeserializerBase
    {
        public string StringToDeserialize { get; private set; }

        public LargeNewtonSoftWrapperDeserializer()
        {
            StringToDeserialize = JsonConvert.SerializeObject(UniformTestObjects.LargeObject);
        }

        public override LargeTestObject TestableAct()
        {
            return JsonConvert.DeserializeObject<LargeTestObject>(StringToDeserialize);
        }
    }
}

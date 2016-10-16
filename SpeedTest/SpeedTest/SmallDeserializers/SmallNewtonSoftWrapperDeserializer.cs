using Newtonsoft.Json;
using SpeedTest.TestObjects;

namespace SpeedTest.SmallDeserializers
{
    public class SmallNewtonSoftWrapperDeserializer : SmallObjectDeserializerBase
    {
        private string StringToDeserialize { get; set; }

        public SmallNewtonSoftWrapperDeserializer()
        {
            StringToDeserialize = JsonConvert.SerializeObject(UniformTestObjects.SmallObject);
        }

        public override SmallTestObject TestableAct()
        {
            return JsonConvert.DeserializeObject<SmallTestObject>(StringToDeserialize);
        }
    }
}

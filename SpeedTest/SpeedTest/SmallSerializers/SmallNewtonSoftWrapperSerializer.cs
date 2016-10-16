using Newtonsoft.Json;

namespace SpeedTest.SmallSerializers
{
    public class SmallNewtonSoftWrapperSerializer : SmallObjectSerializerBase
    {
        public override string TestableAct()
        {
            return JsonConvert.SerializeObject(UniformTestObjects.SmallObject);
        }
    }
}

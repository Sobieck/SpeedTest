using Newtonsoft.Json;

namespace SpeedTest.LargeSerializers
{
    public class LargeNewtonSoftWrapperSerializer : LargeSerializerBase
    {
        public override string TestableAct()
        {
            return JsonConvert.SerializeObject(testObject);
        }
    }
}

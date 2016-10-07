using Newtonsoft.Json;
using SpeedTest.Interfaces;
using SpeedTest.TestObjects;

namespace SpeedTest.LargeObjectSerialization
{
    public class LargeNewtonSoftSerializer : LargeObjectSerializationBase
    {
        public override ILargeObject Act<ILargeObject>()
        {
            var json = JsonConvert.SerializeObject(testObject);
            return JsonConvert.DeserializeObject<TestObject>(json);
        }
    }
}

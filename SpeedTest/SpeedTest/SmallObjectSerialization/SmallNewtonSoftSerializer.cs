using Newtonsoft.Json;
using SpeedTest.TestObjects;

namespace SpeedTest.SmallObjectSerialization
{
    public class SmallNewtonSoftSerializer : SmallObjectSerializationBase
    {
        public override void Act()
        {
            var json = JsonConvert.SerializeObject(testObject);
            var result = JsonConvert.DeserializeObject<TestObject2>(json);
        }
    }
}

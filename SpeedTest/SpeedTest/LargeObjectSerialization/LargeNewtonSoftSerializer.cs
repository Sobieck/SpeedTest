using Newtonsoft.Json;
using SpeedTest.TestObjects;

namespace SpeedTest.LargeObjectSerialization
{
    public class LargeNewtonSoftSerializer : LargeObjectSerializationBase
    {
        public override void Act()
        {
            var json = JsonConvert.SerializeObject(testObject);
            var result = JsonConvert.DeserializeObject<TestObject>(json);
        }
    }
}

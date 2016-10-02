using Newtonsoft.Json;
using SpeedTest.AbstractClasses;
using SpeedTest.TestObjects;

namespace SpeedTest.Serialization
{
    public class SmallNewtonSoftSerializer : SmallObjectBase
    {
        public override void Act()
        {
            var json = JsonConvert.SerializeObject(testObject);
            var result = JsonConvert.DeserializeObject<TestObject2>(json);
        }
    }
}

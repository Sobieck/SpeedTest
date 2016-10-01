using Newtonsoft.Json;
using SpeedTest.TestObjects;

namespace SpeedTest.Serialization
{
    public class SmallNewtonSoft : SmallObjectBase
    {
        public override void Act()
        {
            var json = JsonConvert.SerializeObject(testObject);
            var result = JsonConvert.DeserializeObject<TestObject2>(json);
        }
    }
}

using Newtonsoft.Json;
using SpeedTest.Interfaces;
using SpeedTest.TestObjects;

namespace SpeedTest.SmallObjectSerialization
{
    public class SmallNewtonSoftSerializer : SmallObjectSerializationBase
    {
        public override IEmployee TestableAct()
        {
            var json = JsonConvert.SerializeObject(testObject);
            return JsonConvert.DeserializeObject<Employee>(json);
        }
    }
}

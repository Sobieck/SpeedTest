using SpeedTest.TestObjects;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace SpeedTest.SmallDeserializers
{
    public class SmallNewtonSoftStreamDeserializer : SmallObjectDeserializerBase
    {
        private string StringToDeserialize { get; set; }
        private JsonSerializer jsonSerializer;

        public SmallNewtonSoftStreamDeserializer()
        {
            StringToDeserialize = JsonConvert.SerializeObject(UniformTestObjects.SmallObject);
            jsonSerializer = new JsonSerializer();
        }

        public override SmallTestObject TestableAct()
        {
            var bytesToDeserialize = Encoding.UTF8.GetBytes(StringToDeserialize);

            using (var memoryStream = new MemoryStream(bytesToDeserialize))
            using (var reader = new StreamReader(memoryStream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return jsonSerializer.Deserialize<SmallTestObject>(jsonReader);
            }
        }
    }
}

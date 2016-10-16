using System;
using SpeedTest.TestObjects;
using Newtonsoft.Json;
using System.IO;

namespace SpeedTest.SmallDeserializers
{
    public class SmallNewtonSoftManualMapDeserializer : SmallObjectDeserializerBase
    {
        private string StringToDeserialize { get; set; }
        private JsonSerializer jsonSerializer;

        public SmallNewtonSoftManualMapDeserializer()
        {
            StringToDeserialize = JsonConvert.SerializeObject(UniformTestObjects.SmallObject);
            jsonSerializer = new JsonSerializer();
        }

        public override SmallTestObject TestableAct()
        {
            var response = new SmallTestObject();
            var currentProperty = string.Empty;

            using (var reader = new StringReader(StringToDeserialize))
            using (var jsonTextReader = new JsonTextReader(reader))
            {
                while (jsonTextReader.Read())
                {
                    if(jsonTextReader.Value != null)
                    {
                        if (jsonTextReader.TokenType == JsonToken.PropertyName)
                        {
                            currentProperty = jsonTextReader.Value.ToString();
                        }

                        if (jsonTextReader.TokenType == JsonToken.Integer && currentProperty == "EmployeeNumber")
                        {
                            response.EmployeeNumber = int.Parse(jsonTextReader.Value.ToString());
                        }
                        if (jsonTextReader.TokenType == JsonToken.String && currentProperty == "Name")
                        {
                            response.Name = jsonTextReader.Value.ToString();
                        }
                        if (jsonTextReader.TokenType == JsonToken.Float && currentProperty == "PayPerHour")
                        {
                            response.PayPerHour = decimal.Parse(jsonTextReader.Value.ToString());
                        }
                        if (jsonTextReader.TokenType == JsonToken.String && currentProperty == "Position")
                        {
                            response.Position = jsonTextReader.Value.ToString();
                        }
                            
                    }
                }
            }

            return response;
        }
    }
}

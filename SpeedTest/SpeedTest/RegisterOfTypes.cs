using SpeedTest.MappingTests;
using System.Collections.Generic;

namespace SpeedTest
{
    public static class RegisterOfTypes
    {
        private static Dictionary<string, Base> dictoraryOfTypes = new Dictionary<string, Base> { { "(1) SmallObjectAutoMapper", new SmallObjectAutoMapper() }, { "(2) SmallObjectStaticMapper", new SmallObjectStaticMapper() } };

        public static Dictionary<string, Base> DictoraryOfTypes
        {
            get
            {
                return dictoraryOfTypes;
            }
        }
    }
}

using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System;
using SpeedTest.AbstractClasses;
using AutoMapper;
using SpeedTest.TestObjects.DTO;
using SpeedTest.TestObjects;

namespace SpeedTest
{
    public static class RegisterOfTypes
    {
        private static Dictionary<string, Base> dictoraryOfTypes = new Dictionary<string, Base>();

        static RegisterOfTypes()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var types = assembly.GetTypes();

            foreach (var type in types)
            {
                if(type.IsSubclassOf(typeof(Base)) && !type.IsAbstract)
                {
                    var countOfDictionary = dictoraryOfTypes.Count();
                    var typeName = string.Format("({0}) {1}", countOfDictionary, type.Name);

                    dictoraryOfTypes.Add(typeName, (Base)Activator.CreateInstance(type));
                }
            }

            dictoraryOfTypes.OrderBy(x => x.Value.TypeOfTest);

            
        }

        public static Dictionary<string, Base> DictoraryOfTypes
        {
            get
            {
                return dictoraryOfTypes;
            }
        }


    }
}

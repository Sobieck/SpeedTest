using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedTest.Interfaces;
using SpeedTest.SmallObjectMapping;
using SpeedTest.TestObjects;
using System.Collections.Generic;
using FluentAssertions;
using SpeedTest.SmallObjectSerialization;

namespace SpeedTest.UnitTests
{
    [TestClass]
    public class SmallObjectTestBase
    {
        private Employee expectedObject = UniformTestObjects.SmallObject;
        private Dictionary<string, IEmployee> collectionOfObjectsToTest;

        [TestInitialize]
        public void Initialize()
        {
            collectionOfObjectsToTest = new Dictionary<string, IEmployee>
            {
                {"Small Object Static Mapper", new  SmallObjectStaticMapper().TestableAct()},
                {"Small Object Map In Class", new SmallObjectMapInClass().TestableAct() },
                {"Small Object Automapper", new SmallObjectAutoMapper().TestableAct() },
                {"Small Object Json Serializer", new SmallNewtonSoftSerializer().TestableAct() }
            };
        }

        [TestMethod]
        public void EmployeeNumberShouldBePresent()
        {
            foreach (var item in collectionOfObjectsToTest)
            {
                item.Value.ShouldBeEquivalentTo(expectedObject, item.Key);
            }
        }
    }
}

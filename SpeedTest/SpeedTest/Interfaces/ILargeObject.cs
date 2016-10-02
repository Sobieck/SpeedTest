using SpeedTest.TestObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SpeedTest.Interfaces
{
    public interface ILargeObject
    {
        int RInt { get; set; }
        string RString { get; set; }
        decimal RDecimal { get; set; }
        double RDouble { get; set; }
        int RInt2 { get; set; }
        string RString2 { get; set; }
        decimal RDecimal2 { get; set; }
        double RDouble2 { get; set; }
        TestEnum REnum { get; set; }
        ICollection<TestEnum> REnumCollection { get; set; }
        IList<TestEnum> REnumList { get; set; }
        Guid RGuid { get; set; }
        Employee TestObject2 { get; set; }
        Employee TestObject3 { get; set; }
        List<double> RList { get; set; }
        IList<string> RList2 { get; set; }
        Collection<int> RCollection { get; set; }
        ICollection<bool> RCollection2 { get; set; }
        List<Employee> RTestObject2List { get; set; }
        ICollection<Employee> RTestObject2Collection { get; set; }
        DateTime RDateTime { get; set; }
        ICollection<short> LazyShorts { get; set; }
        ICollection<List<Collection<bool>>> CrazyBools { get; set; }
        string[] Strings { get; set; }
        Employee[] RTestObject2Array { get; set; }
    }
}

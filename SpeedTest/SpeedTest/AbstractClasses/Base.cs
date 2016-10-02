using SpeedTest.Interfaces;

namespace SpeedTest.AbstractClasses
{
    public abstract class Base
    {
        public abstract void Act();

        public abstract string TypeOfTest { get; }
    }
}

using SpeedTest.Interfaces;

namespace SpeedTest.AbstractClasses
{
    public abstract class SpeedTestBase
    {
        public abstract void Act();

        public abstract string TypeOfTest { get; }
    }
}

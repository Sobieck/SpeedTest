using SpeedTest.Interfaces;
using SpeedTest.TestObjects;

namespace SpeedTest.AbstractClasses
{
    public abstract class LargeObjectBase : Base, ITestableClass<ILargeObject>
    {
        public LargeObjectBase()
        {
            testObject = UniformTestObjects.LargeObject;
        }

        public override void Act()
        {
            TestableAct();
        }

        protected TestObject testObject { get; private set; }

        public abstract ILargeObject TestableAct();
    }
}

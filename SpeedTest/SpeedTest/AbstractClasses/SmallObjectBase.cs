using SpeedTest.Interfaces;
using SpeedTest.TestObjects;

namespace SpeedTest.AbstractClasses
{
    public abstract class SmallObjectBase : Base, ITestableClass<IEmployee>
    {
        public SmallObjectBase()
        {
            testObject = UniformTestObjects.SmallObject;
        }

        protected Employee testObject { get; private set; }

        public override void Act()
        {
            TestableAct();
        }

        public abstract IEmployee TestableAct();
    }
}

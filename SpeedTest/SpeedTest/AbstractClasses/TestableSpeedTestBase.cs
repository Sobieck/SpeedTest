using System;

namespace SpeedTest.AbstractClasses
{
    public abstract class TestableSpeedTestBase<T> : SpeedTestBase where T : class
    {
        public abstract T TestableAct();

        public override void Act()
        {
            TestableAct();
        }
    }
}

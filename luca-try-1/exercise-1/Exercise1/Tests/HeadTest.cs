﻿

using NUnit.Framework;

namespace Exercise1.Tests
{
    [TestFixture]
    public class HeadTest
    {
        private Head _target;


        [SetUp]
        public void SetUp()
        {
            _target = new Head();
        }

        [Test]
        public void has_a_positive_max_charge()
        {

            Assert.LessOrEqual(0, _target.MaxCharge);
        }

        [Test]
        public void has_an_onoff_status()
        {
            Assert.IsFalse(_target.IsOn);
        }
    }
}
using System;
using Xunit;

namespace test
{
    public class UnitTest1
    {
        [Fact]
        public void SomaDoisInteiros()
        {
            Calculadora calc = new Calculadora();
            int r = calc.Soma(2,3);
            Assert.Equal(5, r);
        }
    }
}

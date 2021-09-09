using System;
using Xunit;

namespace MyFirstCs.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void fourIsModuloszero()
        { 
            int yearA = 111;
            int yearB = 1921;
            int yearC = 400;
            int yearD = 844;
            
            
            Assert.Equal(MyFirstCs.Program.isLeapYear(yearA),true);
            Assert.NotEqual(MyFirstCs.Program.isLeapYear(yearA),true);

            Assert.Equal(MyFirstCs.Program.isLeapYear(yearB), true);
            Assert.NotEqual(MyFirstCs.Program.isLeapYear(yearB), true);

            Assert.Equal(MyFirstCs.Program.isLeapYear(yearC), true);
            Assert.NotEqual(MyFirstCs.Program.isLeapYear(yearC), true);

            Assert.Equal(MyFirstCs.Program.isLeapYear(yearD), true);
            Assert.NotEqual(MyFirstCs.Program.isLeapYear(yearD), true);
        }
    }
}

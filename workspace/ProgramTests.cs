using HelloWorld;  // The namespace of your hello world application
using Xunit;

namespace HelloWorldTests
{
    public class ProgramTests
    {
        [Fact]
        public void Test1()
        {
            var output = Program.GetHelloWorld();
            Assert.Equal("Hello World!", output);
        }
    }
}

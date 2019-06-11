using NotebookLibrary;
using System;
using Xunit;

namespace NotebookTests
{
    public class LibraryTests
    {
        [Fact]
        public void TestThing()
        {
            Assert.Equal(42, new Thing().Get(19,23));
        }
    }
}

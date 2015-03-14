using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpineer.Parser.Dll;
using Sharpineer.Parser.Header;

namespace Sharpineer.Generator
{
    [TestFixture]
    public class GeneratorTest
    {
        [Test]
        public void User32Dll()
        {
            var gen = new Generator("User32", "User32Dll");
            gen.Generate(@"..\..\..\..\User32Dll");
        }
    }
}

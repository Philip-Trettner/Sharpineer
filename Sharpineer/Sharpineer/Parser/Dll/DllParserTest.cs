using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sharpineer.Parser.Dll
{
    [TestFixture]
    public class DllParserTest
    {
        [Test]
        public void EnumTest()
        {
            var parser = new DllParser("ClangSharp.dll");
            parser.Parse();
        }
    }
}

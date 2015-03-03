using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sharpineer.Parser.Header
{
    [TestFixture]
    public class HeaderParserTest
    {
        [Test]
        public void EnumTest()
        {
            var parser = new HeaderParser("data/EnumTestHeader.h");
            parser.Parse();
        }
    }
}

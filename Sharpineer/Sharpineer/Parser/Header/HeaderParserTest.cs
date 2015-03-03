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

            var enums = parser.Enums;

            /*
            enum FooE
            {
	            Entry1,
	            Entry2,
	            Entry4 = 4
            };

            enum class FooEC
            {
	            Val0,
	            Val1,
	            Val2
            };

            enum class FooECB : short
            {
	            ShortV0,
	            ShortV1,
	            ShortV2,
            };
            */

            {
                var e = enums.FirstOrDefault(ei => ei.Name == "FooE");
                Assert.NotNull(e);

                Assert.AreEqual(e.Name, "FooE");
                Assert.AreEqual(e.BaseType, "int");

                Assert.AreEqual(e.Values["Entry1"], 0L);
                Assert.AreEqual(e.Values["Entry2"], 1L);
                Assert.AreEqual(e.Values["Entry4"], 4L);
            }

            {
                var e = enums.FirstOrDefault(ei => ei.Name == "FooEC");
                Assert.NotNull(e);

                Assert.That(e.Values.ContainsKey("Val1"));
            }

            {
                var e = enums.FirstOrDefault(ei => ei.Name == "FooECB");
                Assert.NotNull(e);

                Assert.AreEqual(e.BaseType, "short");
            }
        }

        [Test]
        public void EnumWindowsTest()
        {
            var parser = new HeaderParser("Windows.h");
            parser.Parse();

            var enums = parser.Enums;
            Assert.Greater(enums.Count, 0);
        }
    }
}

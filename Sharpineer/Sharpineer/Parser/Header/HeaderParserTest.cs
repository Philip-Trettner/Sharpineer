using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;
using NUnit.Framework;

namespace Sharpineer.Parser.Header
{
    [TestFixture]
    public class HeaderParserTest
    {
        [Test]
        public void Enums()
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
        public void EnumWindows()
        {
            var parser = new HeaderParser("Windows.h");
            parser.Parse();

            var enums = parser.Enums;
            Assert.Greater(enums.Count, 0);
        }

        [Test]
        public void ExternFunctions()
        {
            var parser = new HeaderParser("data/ExternFunctionTestHeader.h");
            parser.Parse();

            /*
            extern "C" void foo()
            {

            }

            extern "C" int bar(char c, short s, bool b)
            {

            }

            extern "C"
            {
	            void baz(int i)
	            {

	            }

	            bool qux(void *i)
	            {

	            }
            }
            */

            var funcs = parser.ExternFunctions;

            {
                var f = funcs.FirstOrDefault(fi => fi.Name == "foo");
                Assert.NotNull(f);

                Assert.AreEqual(f.Name, "foo");
                Assert.AreEqual(f.ReturnType.Type, CXTypeKind.CXType_Void);
                Assert.IsEmpty(f.Parameters);
            }

            {
                var f = funcs.FirstOrDefault(fi => fi.Name == "foof");
                Assert.NotNull(f);

                Assert.AreEqual(f.Name, "foof");
                Assert.AreEqual(f.ReturnType.Type, CXTypeKind.CXType_Void);
                Assert.IsEmpty(f.Parameters);
            }

            {
                var f = funcs.FirstOrDefault(fi => fi.Name == "bar");
                Assert.NotNull(f);

                Assert.AreEqual(f.Name, "bar");
                Assert.AreEqual(f.ReturnType.Type, CXTypeKind.CXType_Int);
                Assert.AreEqual(f.Parameters.Count, 3);

                Assert.AreEqual(f.Parameters[0].Name, "c");
                Assert.AreEqual(f.Parameters[1].Name, "s");
                Assert.AreEqual(f.Parameters[2].Name, "i");

                Assert.AreEqual(f.Parameters[0].Type.Name, "char");
                Assert.AreEqual(f.Parameters[1].Type.Name, "short");
                Assert.AreEqual(f.Parameters[2].Type.Name, "bool");
            }

            {
                var f = funcs.FirstOrDefault(fi => fi.Name == "baz");
                Assert.NotNull(f);
            }

            {
                var f = funcs.FirstOrDefault(fi => fi.Name == "qux");
                Assert.NotNull(f);
            }
        }
    }
}

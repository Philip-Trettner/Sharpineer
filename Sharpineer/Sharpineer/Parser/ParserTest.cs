using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sharpineer.Parser.Dll;
using Sharpineer.Parser.Header;

namespace Sharpineer.Parser
{
    [TestFixture]
    public class ParserTest
    {
        [Test]
        public void CombinedUser32()
        {
            var hparser = new HeaderParser("Windows.h");
            var dparser = new DllParser(@"c:\windows\system32\user32.dll");

            hparser.Parse();
            dparser.Parse();

            hparser.NotifyDll("User32.dll", dparser.FunctionNames);

            var f = hparser.ExternFunctions["GetWindowTextA"];
            Assert.NotNull(f);
            Assert.AreEqual(f.DllName, "User32.dll");
        }
    }
}

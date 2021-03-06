﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
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
            hparser.MergeAnsiUnicode();

            {
                var f = hparser.ExternFunctions["GetWindowText"];
                Assert.NotNull(f);
                Assert.AreEqual(f.DllName, "User32.dll");
            }

            var userFuncs = hparser.ExternFunctions.Values.Where(f => f.DllName == "User32.dll" && !f.HasUnnamedParameter).ToList();
            Assert.IsNotEmpty(userFuncs);

            //File.WriteAllLines(@"C:\Temp\userfuncs.txt", userFuncs.OrderBy(f => f.Name).Select(f => f.Name + "(" + (f.Parameters.Count == 0 ? " " : f.Parameters.Select(p => p.ToString()).Aggregate((s1, s2) => s1 + ", " + s2)) + ") -> " + f.ReturnType));
            
            var list = new List<string>();
            foreach (var func in userFuncs.OrderBy(f => f.Name))
            {
                list.Add("");
                list.Add(func.DllImportString);
                list.Add(func.FunctionDeclaration);
            }
            list.Add("");
            list.Add("");
            foreach (var @struct in hparser.Structs.Values)
            {
                list.Add("");
                list.AddRange(@struct.CSharpDefinition);
            }

            //File.WriteAllLines(@"C:\Temp\userfuncs-sharp.txt", list);
        }
    }
}

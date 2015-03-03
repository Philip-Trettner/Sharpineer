using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClangSharp;

namespace Sharpineer.Parser.Header
{
    public class HeaderParser
    {
        /// <summary>
        /// All header files
        /// </summary>
        public readonly string[] HeaderFiles;

        public HeaderParser(params string[] headerFiles)
        {
            HeaderFiles = headerFiles;
        }

        /// <summary>
        /// Parses all headers using libClang
        /// </summary>
        public void Parse()
        {
            var createIndex = clang.createIndex(0, 0);

            var args = new List<string> { "-x", "c++", "-I./" };

            var tmpfile = Path.GetTempFileName();
            var lines = HeaderFiles.Select(header => "#include \"" + header + "\"").ToList();
            File.WriteAllLines(tmpfile, lines);

            CXTranslationUnit translationUnit;
            CXUnsavedFile unsavedFile;
            var translationUnitError = clang.parseTranslationUnit2(createIndex, tmpfile, args.ToArray(), args.Count, out unsavedFile, 0, 0, out translationUnit);

            if (translationUnitError != CXErrorCode.CXError_Success)
            {
                Console.WriteLine("Error: " + translationUnitError);
                var numDiagnostics = clang.getNumDiagnostics(translationUnit);

                for (uint i = 0; i < numDiagnostics; ++i)
                {
                    var diagnostic = clang.getDiagnostic(translationUnit, i);
                    Console.WriteLine(clang.getDiagnosticSpelling(diagnostic).ToString());
                    clang.disposeDiagnostic(diagnostic);
                }

                throw new InvalidOperationException("Error while compiling");
            }
        }
    }
}

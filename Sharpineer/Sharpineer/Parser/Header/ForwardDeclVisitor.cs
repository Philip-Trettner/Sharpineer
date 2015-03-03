using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClangSharp;
using Sharpineer.Helper;

namespace Sharpineer.Parser.Header
{
    public class ForwardDeclVisitor
    {
        private readonly CXCursor startCursor;
        private bool startCursorReached;

        public ForwardDeclVisitor(CXCursor startCursor)
        {
            this.startCursor = startCursor;
        }

        public CXCursor ForwardDeclarationCursor { get; private set; }

        public CXChildVisitResult Visit(CXCursor cursor, CXCursor parent, IntPtr data)
        {
            if (cursor.IsInSystemHeader())
                return CXChildVisitResult.CXChildVisit_Continue;

            if (clang.equalCursors(cursor, startCursor) != 0)
            {
                startCursorReached = true;
                return CXChildVisitResult.CXChildVisit_Continue;
            }

            if (startCursorReached)
            {
                ForwardDeclarationCursor = cursor;
                return CXChildVisitResult.CXChildVisit_Break;
            }

            return CXChildVisitResult.CXChildVisit_Recurse;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Compiler
    {
        Library _lib;

        public Compiler()
        {
            _lib = new Library();
        }

        public CompilerResult Compile(string[] instructions)
        {
            Tokeniser t = new Tokeniser(instructions);
            List<OpCode> code = new List<OpCode>();
            List<string> errorMessages = new List<string>();
            OpCodeRootResult result;
            OpCodeRoot _opCodeRoot;

            while (t.MatchNextToken())
            {
                t.MatchSpace();
                if (t.IsEnd)
                {
                    code.Add(null);
                }
                else if (t.IsDirective(out _opCodeRoot))
                {

                    result = _opCodeRoot.Parse(t);

                    if (result.IsSuccess) code.Add(result.OpCode);
                    else errorMessages.Add(result.ErrorMessage);
                }
                else if (t.IsInstruction(out _opCodeRoot))
                {
                    result = _opCodeRoot.Parse(t);

                    if (result.IsSuccess) code.Add(result.OpCode);
                    else errorMessages.Add(result.ErrorMessage);
                }
                else if (t.IsLabel(out _opCodeRoot))
                {
                    result = _opCodeRoot.Parse(t);
                    if (result.IsSuccess) code.Add(result.OpCode);
                    else errorMessages.Add(result.ErrorMessage);
                }
                else
                {
                    errorMessages.Add("Error line " + t.CurentLigne + " : Syntaxe Error");
                }
            }

            if (errorMessages.Count == 0)
            {
                return new CompilerResult(new CompiledCode(code));
            }
            else
            {
                return new CompilerResult(errorMessages);
            }
        }
    }
}

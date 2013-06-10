using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnatomIL
{
    public class Compiler
    {

        public Compiler()
        {
        }

        public CompilerResult Compile(Tokeniser t)
        {
            List<OpCode> code = new List<OpCode>();
            List<string> errorMessages = new List<string>();
            OpCodeRootResult result;
            OpCodeRoot _opCodeRoot;
            List<string> args = new List<string>();
            PrototypeOpCodeRoot prototype = new PrototypeOpCodeRoot();


            while (t.MatchNextToken())
            {
                if (t.SquareBraket)
                {
                    result = prototype.Parse(t);
                    if (result.IsSuccess)
                    {
                        if (result.OpCode != null && !(t.MatchNextToken() && t.MatchOpenBraket())) errorMessages.Add("missing '{' line :" + (t.CurentLigne + 1));
                        else if (result.OpCode != null) code.Add(null);
                        code.Add(result.OpCode);
                    }
                    else errorMessages.Add(result.ErrorMessage);

                   
                }
                else
                {
                    if (t.IsEnd) code.Add(null);
                    else if (t.MatchcloseBraket())
                    {
                        if (!t.IsEnd) errorMessages.Add("syntaxe error line :" + t.CurentLigne);
                        else code.Add(new RetOpCode(t.CurentLigne));
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
                        errorMessages.Add("Error line " + (t.CurentLigne + 1) + " : Syntaxe Error");
                    }
                }
            }

            bool main = false;

            foreach (var c in code)
            {
                if (c != null && c.NameFrame == "main") main = true;
                if (c != null && c.Name == "call")
                {
                    bool tmp = false;
                    foreach (var a in code)
                    {
                        if (a != null && a.NameFrame == c.Target) tmp = true;
                    }
                    if (!tmp) errorMessages.Add("Error line " + (c.Line + 1) + " : fuction " + c.Target + " can't be call does not existe");
                }
            }

            if (!main) errorMessages.Add("Missing main function");

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

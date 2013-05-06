using System;
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
            List<OpCode> code = new List<OpCode>();
            List<string> errorMessages = new List<string>();
            OpCodeRootResult result;

            for (int i = 0; i < instructions.Count(); i++ )
            {
                
                string instruction = instructions[i];

                // retire les espace en trop
                instruction.Trim();
                while (instruction.Contains("  "))
                {
                    instruction = instruction.Replace("  ", " ");
                }
                instruction = instruction.Replace(". ", ".");

                // on recupére le nom de la méthode, les options et les arguments
                string operation = instruction.Split('.', ' ')[0];
                if (operation == "") operation = instruction.Split('.', ' ')[1];
                List<string> options = instruction.Split('.').ToList();
                List<string> args = options[options.Count() - 1].Split(' ').ToList();
                if (args[0] == "") { args.RemoveAt(0); }
                args.RemoveAt(0);
                options[options.Count() - 1] = options[options.Count() - 1].Split(' ')[0];
                options.RemoveAt(0);

                if (instruction != "")
                {
                    if (_lib.LibIsCodeOpRootExiste(operation))
                    {
                        result = _lib.LibFindOpCodeRoot(operation).Parse(options, args);

                        if (result.IsSuccess) code.Add(result.OpCode);
                        else errorMessages.Add("Error line " + i.ToString() + " : " + result.ErrorMessage);
                    }
                    else if (instruction[0] == ':')
                    {
                        List<string> label = new List<string>();
                        label.Add(instruction);
                        result = _lib.LibFindOpCodeRoot("label").Parse(label, args);

                        if (result.IsSuccess) code.Add(result.OpCode);
                        else errorMessages.Add("Error line " + i.ToString() + " : " + result.ErrorMessage);
                    }
                    else if (operation == "locals")
                    {
                        if (args[0] == "init" && args[1][0] == '(')
                        {
                            args[1] = args[1].Remove(0,1);
                            options = new List<string>();

                            options.Add(args[1].Remove(args[1].Length - 1, 1));
                            int j = i;
                            j++;

                            while ((instructions[j][instructions[j].Length - 1] == ')'  || instructions[j][instructions[j].Length - 1] == ',')
                                    && j < instructions.Count())
                            {
                                instruction = instructions[j];
                                instruction.Trim();
                                options.Add(instruction.Remove(instruction.Length - 1, 1));
                                j++;
                            }

                            result = _lib.LibFindOpCodeRoot("localsInit").Parse(options, args);

                            if (result.IsSuccess) code.Add(result.OpCode);
                            else errorMessages.Add("Error line " + i.ToString() + " : " + result.ErrorMessage);

                            while (j - 1 > i)
                            {
                                code.Add(null);
                                i++;
                            }
                        }
                        else
                        {
                            errorMessages.Add("Compilation error : line " + (i + 1).ToString());
                        }
                    }
                    else
                    {
                        errorMessages.Add("Compilation error : line " + (i + 1).ToString() + ", instruction : \"" + operation + "\" can't be found in library");
                    }
                }
                else
                {
                    code.Add(null);
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

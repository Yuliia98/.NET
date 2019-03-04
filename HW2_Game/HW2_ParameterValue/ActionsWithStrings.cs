using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_ParameterValue
{
    class ActionsWithStrings
    {
        public static void GetHelp()
        {
            Console.WriteLine("Wrong input data. Short help :)\n");
            Console.WriteLine("Parameters: number, flag, string\n 1) “number” can be any integer number, mandatory parameter\n 2) “flag” is bool\n 3) “string” any non-empty quoted string\nParameter starts with “--”.\nValue is divided from parameter with space\n");

        }

        public static void FlagCheck(string[] array)
        {

            if (array[1] == "false" || array[1] == "true")
            {
                Console.WriteLine($"Result - {array[0]}: {array[1]}");
            }
            else
            {
                GetHelp();
            }

        }

        public static bool CheckNumberType(string[] line)
        {
            string[] integers = { "sbyte", "byte", "char", "short", "ushort", "int", "uint", "long", "ulong" };
            for (int i = 0; i < integers.Length; i++)
            {
                if (line[0] == integers[i])
                {
                    return true;
                }
            }
            return false;

        }

        public static void CheckNumber(string[] line)
        {
            try
            {
                var number = 0;
                number = int.Parse(line[1]);
                Console.WriteLine($"Result: {line[0]}: {number}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetHelp();
            }
        }

        public static void AnalyzeInput()
        {
            var answer = "";
            var line = "";
            var flag = "flag";
            var inString = "string";
            do
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Please enter string: ");
                        line = Console.ReadLine();
                        var s1 = line[0];
                        var s2 = line[1];
                        var newLine = line.Remove(0, 2);
                        var strings = newLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                        if (s1.ToString() == "-" && s2.ToString() == "-" && strings.Length == 2)
                        {
                            if (strings[0] == inString)
                            {
                                Console.WriteLine($"Result: {strings[0]}: {strings[1]}");
                                break;
                            }
                            else if (CheckNumberType(strings) == true)
                            {
                                CheckNumber(strings);
                                break;
                            }
                            else if (strings[0] == flag)
                            {
                                FlagCheck(strings);
                                break;
                            }
                            else
                            {
                                GetHelp();
                            }
                        }
                        else if (strings[0] == flag)
                        {
                            Console.WriteLine($"Result: {strings[0]}: true");
                            break;
                        }
                        else
                        {
                            GetHelp();
                        }
                    }
                    catch
                    {
                        GetHelp();
                    }
                }
                Console.WriteLine("Continue?(y/n)");
                answer = Console.ReadLine();
            } while (answer != "n");
        }

    }
}

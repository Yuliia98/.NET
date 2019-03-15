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
            Console.WriteLine("Incorrect input. Short help :)\nParameters: number, flag, string\n 1) “number” can be any integer number, mandatory parameter\n 2) “flag” is bool\n 3) “string” any non-empty quoted string\nParameter starts with “--”.\nValue is divided from parameter with '='\n");
        }


        public static void CheckInput()
        {
            Console.WriteLine("Enter string or enter 'stop' to finish: ");
            var input = Console.ReadLine();
            var values = input.Split(' ');
            do
            {
                for (int i = 0; i < values.Length; i++)
                {

                    if (values[i].StartsWith("--flag"))
                    {
                        try
                        {
                            var str = values[i].Remove(0, 2);
                            var parval = str.Split('=');
                            if (parval[1] == "true" || parval[1] == "false")
                            {
                                Console.WriteLine($"{parval[0]} : {parval[1]}");
                            }
                            else
                            {
                                GetHelp();
                            }
                        }
                        catch
                        {
                            Console.WriteLine("flag : true");
                        }
                    }
                    else if (values[i].StartsWith("--string"))
                    {
                        try
                        {
                            var str = values[i].Remove(0, 2);
                            var parval = str.Split('=');
                            Console.WriteLine($"{parval[0]} : {parval[1]}");

                        }
                        catch
                        {
                            Console.WriteLine("string : non value");
                        }
                    }
                    else if (values[i].StartsWith("--number"))
                    {
                        try
                        {
                            try
                            {
                                var str = values[i].Remove(0, 2);
                                var parval = str.Split('=');
                                var number = int.Parse(parval[1]);
                                Console.WriteLine($"{parval[0]} : {number}");
                            }
                            catch
                            {
                                GetHelp();
                            }

                        }
                        catch
                        {
                            Console.WriteLine("number : non value");
                        }
                    }
                    else
                    {
                        GetHelp();
                    }
                }

                Console.WriteLine("Enter string or enter 'stop' to finish: ");
                input = Console.ReadLine();

            } while (input != "stop");
        }
    }
}

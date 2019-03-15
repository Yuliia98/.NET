using System;

namespace HW2_ParameterValue
{
    class ActionsWithStrings
    {
        public static void GetHelp()
        {
            const string message =
                "\nIncorrect input. Short help :)\n" +
                "Parameters: number, flag, string\n" +
                "1) “number” can be any integer number, mandatory parameter\n" +
                "2) “flag” is bool\n" +
                "3) “string” any non-empty quoted string\nParameter starts with “--”.\nValue is divided from parameter with '='\n" +
                "4) for example: --flag=true --number=127 --string=Hello, World!\n";

            Console.WriteLine(message);
        }


        public static void CheckInput()
        {
            Console.WriteLine("Enter string or enter 'stop' to finish:");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                GetHelp();
                return;
            }
            var values = input.Split(' ');
            do
            {
                foreach (var t in values)
                { 
                    if (t.StartsWith("--flag"))
                    {
                        try
                        {
                            var str = t.Remove(0, 2);
                            var parval = str.Split('=');
                            if (parval[1] == "true" || parval[1] == "false")
                            {
                                Console.WriteLine($"{parval[0]}   : {parval[1]}");
                            }
                            else
                            {
                                GetHelp();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("flag : true\n");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (t.StartsWith("--string"))
                    {
                        try
                        {
                            var str = t.Remove(0, 2);
                            var parval = str.Split('=');
                            Console.WriteLine($"{parval[0]} : {parval[1]}");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("string : non value\n");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else if (t.StartsWith("--number"))
                    {
                        try
                        {
                            try
                            {
                                var str = t.Remove(0, 2);
                                var parval = str.Split('=');
                                var number = int.Parse(parval[1]);
                                Console.WriteLine($"{parval[0]} : {number}");
                            }
                            catch
                            {
                                GetHelp();
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("number : non value\n");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    else
                    {
                        GetHelp();
                    }
                }

                Console.WriteLine("\nEnter string or enter 'stop' to finish:");
                input = Console.ReadLine();

            } while (input?.ToLower() != "stop");
        }
    }
}
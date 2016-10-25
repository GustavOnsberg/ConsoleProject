using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        //Settings
        //Console settings
        public static bool bEverClearConsole = true;
        public static bool bUseColors = true;
        public static bool bLogConsoleOutputInFile = false;
        public static string strConsoleLogDirectory = @"C:\Users\Public\Console Project";

        static Print print = new Print();
        static PublicCommands publicCommands = new PublicCommands();


        //The text that will be printed if the help command is used
        static String strHelpText = "This is some awesome help text";

        //Command list
        public static String[] strCommandList =
        { "help____________________Help or something."
        , "list____________________Prints a list of all commands to the console."
        , "clear___________________Clears the console"
        , "basiccalculator / bc____Will start the basic calculator"};

        //Message shown if the command is invalid
        static String strInvalidCommandMessage= "The command was invalid";



        public static String[] strCommandsInput;


        static void Main(string[] args)
        {
            print.SetLogConsoleOutputInFile(false);


            Console.Out.WriteLine("Write \"help\" for help or write \"list\" to see list of commands.");


            while (true)
            {
                strCommandsInput = Console.In.ReadLine().Split(' ');
                switch (strCommandsInput[0])
                {
                    case "list":
                        for (int i = 0; i < strCommandList.Length; i++)
                        {
                            Console.Out.WriteLine(strCommandList[i]);
                        }
                        break;

                    case "help":
                        Console.Out.WriteLine(strHelpText);
                        break;

                    case "basiccalculator":
                    case "bc":
                        Console.Out.WriteLine("Starting basic calculator.");
                        if (bEverClearConsole)
                            Console.Clear();
                        new BasicCalulator().Start();
                        break;


                    case "ftree":
                    case "fulltree": new FullTree().Start(); break;


                    case "": break;
                    default: publicCommands.Start(strCommandsInput); break;
                }
            }
        }



        void Stop()
        {

        }
    }
}

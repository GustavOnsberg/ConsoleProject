using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleProject
{
    class Print
    {
        public static bool bLogConsoleOutputInFile = false;
        public static string strConsoleLogDirectory = @"C:\Users\Public\Console Project";
        public static string strLogName = "ConsoleProjectLog" + DateTime.Now + ".CPL";
        StreamWriter streamWriter = new StreamWriter(strConsoleLogDirectory);


        public void Line(string strInput)
        {
            Console.WriteLine(strInput);
            if (bLogConsoleOutputInFile)
            {
                streamWriter.WriteLine(strInput);
            }
        }

        public void Stop()
        {
            streamWriter.Close();
        }


        public void SetLogConsoleOutputInFile(bool bInput)
        {
            bLogConsoleOutputInFile = bInput;
        }
        public void SetConsoleLogDirectory(string strInput)
        {
            strConsoleLogDirectory = strInput;
        }

    }
}

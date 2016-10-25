using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleProject
{
    class FullTree
    {
        string strWorkingDirectory = @"C:\";


        public void Start()
        {
            Tree(strWorkingDirectory);
        }




        string[] strFilesInDirectory;



        void Tree(string strDirectory)
        {
            string[] strFoldersInDirectory = { };
            try
            {
                strFilesInDirectory = Directory.GetFiles(strDirectory);
                strFoldersInDirectory = Directory.GetDirectories(strDirectory);
            }
            catch (Exception)
            {

                
            }
            
            foreach(string strFile in strFilesInDirectory)
            {
                Console.Out.WriteLine(strFile.Split('\\')[strFile.Split('\\').Length - 1]);
            }

            
            foreach (string strFolder in strFoldersInDirectory)
            {
                Tree(strFolder);
            }
        }

    }
}

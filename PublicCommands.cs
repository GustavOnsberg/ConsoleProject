using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class PublicCommands
    {
        static String[] strCommand;
        public void Start(String[] strInput)
        {
            strCommand = strInput;
            switch (strInput[0])
            {
                case "clear": Clear(); break;
                case "color": SetTextColor(); break;
                case "bgcolor":
                case "backgroundcolor":
                case "bgcolour":
                case "backgroundcolour": SetBackgroundColor(); break;

                default: break;
            }
        }





        void Clear()
        {
            Console.Clear();
        }
        


        void SetTextColor()
        {
            int iColorID = 0;
         
            try
            {
                iColorID = Int32.Parse(strCommand[1]);
                if (iColorID < 0 || iColorID > 15)
                {
                    iColorID = Int32.Parse("Too much fail");
                }
                
                switch (iColorID)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.White; break;
                    case 1: Console.ForegroundColor = ConsoleColor.Black; break;
                    case 2: Console.ForegroundColor = ConsoleColor.Blue; break;
                    case 3: Console.ForegroundColor = ConsoleColor.Cyan; break;
                    case 4: Console.ForegroundColor = ConsoleColor.DarkBlue; break;
                    case 5: Console.ForegroundColor = ConsoleColor.DarkCyan; break;
                    case 6: Console.ForegroundColor = ConsoleColor.DarkGray; break;
                    case 7: Console.ForegroundColor = ConsoleColor.DarkGreen; break;
                    case 8: Console.ForegroundColor = ConsoleColor.DarkMagenta; break;
                    case 9: Console.ForegroundColor = ConsoleColor.DarkRed; break;
                    case 10: Console.ForegroundColor = ConsoleColor.DarkYellow; break;
                    case 11: Console.ForegroundColor = ConsoleColor.Gray; break;
                    case 12: Console.ForegroundColor = ConsoleColor.Green; break;
                    case 13: Console.ForegroundColor = ConsoleColor.Magenta; break;
                    case 14: Console.ForegroundColor = ConsoleColor.Red; break;
                    case 15: Console.ForegroundColor = ConsoleColor.Yellow; break;
                        

                    default:
                        break;
                }
                    
            }
            catch (Exception)
            {
                Console.Out.WriteLine("\"" + strCommand[1] + "\" is not a valid color ID");

                Console.Out.WriteLine("0 = White");
                Console.Out.WriteLine("1 = Black");
                Console.Out.WriteLine("2 = Blue");
                Console.Out.WriteLine("3 = Cyan");
                Console.Out.WriteLine("4 = DarkBlue");
                Console.Out.WriteLine("5 = DarkCyan");
                Console.Out.WriteLine("6 = DarkGray");
                Console.Out.WriteLine("7 = DarkGreen");
                Console.Out.WriteLine("8 = DarkMagenta");
                Console.Out.WriteLine("9 = DarkRed");
                Console.Out.WriteLine("10 = DarkYellow");
                Console.Out.WriteLine("11 = Gray");
                Console.Out.WriteLine("12 = Green");
                Console.Out.WriteLine("13 = Magenta");
                Console.Out.WriteLine("14 = Red");
                Console.Out.WriteLine("15 = Yellow");

                strCommand[1] = Console.In.ReadLine();
            }
        }



        void SetBackgroundColor()
        {
            int iColorID = 0;

            try
            {
                iColorID = Int32.Parse(strCommand[1]);
                if (iColorID < 0 || iColorID > 15)
                {
                    iColorID = Int32.Parse("Too much fail");
                }

                switch (iColorID)
                {
                    case 0: Console.BackgroundColor = ConsoleColor.White; break;
                    case 1: Console.BackgroundColor = ConsoleColor.Black; break;
                    case 2: Console.BackgroundColor = ConsoleColor.Blue; break;
                    case 3: Console.BackgroundColor = ConsoleColor.Cyan; break;
                    case 4: Console.BackgroundColor = ConsoleColor.DarkBlue; break;
                    case 5: Console.BackgroundColor = ConsoleColor.DarkCyan; break;
                    case 6: Console.BackgroundColor = ConsoleColor.DarkGray; break;
                    case 7: Console.BackgroundColor = ConsoleColor.DarkGreen; break;
                    case 8: Console.BackgroundColor = ConsoleColor.DarkMagenta; break;
                    case 9: Console.BackgroundColor = ConsoleColor.DarkRed; break;
                    case 10: Console.BackgroundColor = ConsoleColor.DarkYellow; break;
                    case 11: Console.BackgroundColor = ConsoleColor.Gray; break;
                    case 12: Console.BackgroundColor = ConsoleColor.Green; break;
                    case 13: Console.BackgroundColor = ConsoleColor.Magenta; break;
                    case 14: Console.BackgroundColor = ConsoleColor.Red; break;
                    case 15: Console.BackgroundColor = ConsoleColor.Yellow; break;


                    default:
                        break;
                }

            }
            catch (Exception)
            {
                Console.Out.WriteLine("\"" + strCommand[1] + "\" is not a valid color ID");

                Console.Out.WriteLine("0 = White");
                Console.Out.WriteLine("1 = Black");
                Console.Out.WriteLine("2 = Blue");
                Console.Out.WriteLine("3 = Cyan");
                Console.Out.WriteLine("4 = DarkBlue");
                Console.Out.WriteLine("5 = DarkCyan");
                Console.Out.WriteLine("6 = DarkGray");
                Console.Out.WriteLine("7 = DarkGreen");
                Console.Out.WriteLine("8 = DarkMagenta");
                Console.Out.WriteLine("9 = DarkRed");
                Console.Out.WriteLine("10 = DarkYellow");
                Console.Out.WriteLine("11 = Gray");
                Console.Out.WriteLine("12 = Green");
                Console.Out.WriteLine("13 = Magenta");
                Console.Out.WriteLine("14 = Red");
                Console.Out.WriteLine("15 = Yellow");

                strCommand[1] = Console.In.ReadLine();
            }
        }
    }
}

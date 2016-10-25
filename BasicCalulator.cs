using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class BasicCalulator
    {
        static String strInput;
        static Char[] charInputArray;
        static bool bError;


        public void Start()
        {
            Console.Out.WriteLine("This is the basic calculator. For more advanced stuff, use the the advaced calculator. \n\nIf you would like to use the advanced calculator, just write \"advanced\"\nIf not, just write math stuff.");
            MathLoop();
        }

        void MathLoop()
        {
            strInput = Console.In.ReadLine();
            if (strInput == "advanced")
            {
                new AdvancedCalculator().Start();
                
            }
            strInput = strInput.Replace(" ","");

            CheckIfValid();

            while (true)
            {
                int iOpenBracketPos = 0;
                int iCloseBracketPos = 0;
                bool bGotOpenBracket = false;
                bool bCurrentIsOpenBracket = false;
                bool bCurrentIsCloseBraket = false;
                charInputArray = strInput.ToCharArray();
                for (int i = 0; i < charInputArray.Length; i++)
                {
                    if (charInputArray[i] == '(')
                    {
                        bCurrentIsOpenBracket = true;
                        bGotOpenBracket = true;
                        iOpenBracketPos = i;
                    }
                    else if (charInputArray[i] == ')')
                    {
                        if (!bCurrentIsOpenBracket)
                        {
                            Console.Out.WriteLine("There is a problem with the brackets");
                            bError = true;
                            break;
                        }
                        bCurrentIsCloseBraket = true;
                        iCloseBracketPos = i;

                        strInput = strInput.Replace(strInput.Remove(iCloseBracketPos, strInput.Length - iCloseBracketPos).Remove(0, iOpenBracketPos + 1), Calculate(strInput.Remove(iCloseBracketPos, strInput.Length - iCloseBracketPos).Remove(0, iOpenBracketPos + 1)));
                        Console.Out.WriteLine(strInput);
                        Console.In.ReadLine();
                    }


                }
            }
        }

        String Calculate(String strToCalculate)
        {
            Decimal decResult = 0;
            String strToCalculateMod = "";
            String[] strToCalculateModSplit = { };
            String[] strToCalculateOperator = { };


            if (strToCalculate.Contains('^'))
            {
                strToCalculateMod = strToCalculate.Replace("+", "_").Replace("-", "_").Replace("/", "_").Replace("*", "_");
                strToCalculateModSplit = strToCalculateMod.Split('_');
                

                for (int i = 0; i < strToCalculateModSplit.Length; i++)
                {
                    if (strToCalculateModSplit[i].Contains('^'))
                    {
                        strToCalculateOperator = strToCalculateModSplit[i].Split('^');
                        decResult = System.Convert.ToDecimal(strToCalculateOperator[0]);
                        for (int e = 0; e < strToCalculateOperator.Length - 1; e++)
                        {
                            decResult = (Decimal)Math.Pow((double)decResult, (double)System.Convert.ToDecimal(strToCalculateOperator[e + 1]));
                            Console.Out.WriteLine(decResult);
                        }
                    }
                }
                return decResult + "";
            }
            else if (true)
            {

            }
            else if (true)
            {

            }
            else if (true)
            {

            }
            else if (true)
            {

            }


            return "Something went wrong.";
        }


        bool CheckIfValid()
        {
            if ("" == strInput.Replace("1", "").Replace("2", "").Replace("3", "").Replace("4", "").Replace("5", "").Replace("6", "").Replace("7", "").Replace("8", "").Replace("9", "").Replace("0", "").Replace("+", "").Replace("-", "").Replace("*", "").Replace("/", "").Replace("^", "").Replace("(", "").Replace(")", "").Replace("," ,"").Replace(".", ""))
            {
                strInput = strInput.Replace("1(", "1*(").Replace("2(", "2*(").Replace("3(", "3*(").Replace("4(", "4*(").Replace("5(", "5*(").Replace("6(", "6*(").Replace("7(", "7*(").Replace("8(", "8*(").Replace("9(", "9*(").Replace("0(", "0*(").Replace(")1", ")*1").Replace(")2", ")*2").Replace(")3", ")*3").Replace(")4", ")*4").Replace(")5", ")*5").Replace(")6", ")*6").Replace(")7", ")*7").Replace(")8", ")*8").Replace(")9", ")*9").Replace(")0", ")*0").Replace(")(", ")*(").Replace("()", "0").Replace(".", ",");
                strInput = "(" + strInput + ")";
                return true;
            }
            Console.Out.WriteLine("Input contained invalid character.");


            return false;
        }
    }
}

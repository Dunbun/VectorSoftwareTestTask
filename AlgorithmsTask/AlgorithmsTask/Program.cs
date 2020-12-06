using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTask
{
    class Program
    {
        static int GetStepInOuterRail(int AmountOfRails)
        {
            if (AmountOfRails >= 2)
                return (2 * AmountOfRails - 2);
            else
                return 0;
        }

        static int GetFirstStepInInnerRail(int AmountOfRails, int RailNumber)
        {
            if (AmountOfRails >= 2 && RailNumber < AmountOfRails)
                return (2 * AmountOfRails - 2 * RailNumber);
            else
                return 0;
        }

        static int GetSumOfFirstAndSecondInnerSteps(int AmountOfRails)
        {
            return (2 * AmountOfRails - 2);
        }

        static string EncodeMethod(int AmountOfRails, string LineToEncode)
        {
            if (AmountOfRails < 2)
                return null;
            if (LineToEncode.Length == 0)
                return LineToEncode;

            int StepInOuterRail = GetStepInOuterRail(AmountOfRails);
            int SumOfFirstAndSecondInnerSteps = GetSumOfFirstAndSecondInnerSteps(AmountOfRails);
            string [] EncodedLine = new string[LineToEncode.Length];
            int StepPosition = 0;
            int PositionInLineToEncode = 0;
            int PositionInEncodedLine = 0;
            int Step = 0;
            bool IsInnerRail = false;
            
            for (int RailCounter = 1; RailCounter <= AmountOfRails; RailCounter++)
            {
                if (RailCounter == 1 || RailCounter == AmountOfRails)
                    Step = StepInOuterRail;
                else
                {
                    Step = GetFirstStepInInnerRail(AmountOfRails, RailCounter);
                    IsInnerRail = true;
                }

                StepPosition = PositionInLineToEncode;

                while (StepPosition < LineToEncode.Length)
                {
                    EncodedLine[PositionInEncodedLine] = LineToEncode[StepPosition].ToString();
                    PositionInEncodedLine++;
                    StepPosition = StepPosition + Step;

                    if (IsInnerRail)      
                        Step = SumOfFirstAndSecondInnerSteps - Step;                                      
                }

                PositionInLineToEncode++;
                IsInnerRail = false;
            }
            
            return string.Join("",EncodedLine);
        }

        static string DecodeMethod(int AmountOfRails, string EncodedLine)
        {
            if (AmountOfRails < 2)
                return null;
            if (EncodedLine.Length == 0)
                return EncodedLine;

            int StepInOuterRail = GetStepInOuterRail(AmountOfRails);
            int SumOfFirstAndSecondInnerSteps = GetSumOfFirstAndSecondInnerSteps(AmountOfRails);
            string[] DecodedLine = new string[EncodedLine.Length];
            int StepPosition = 0;
            int PositionInDecodedLine = 0;
            int PositionInEncodedLine = 0;
            int Step = 0;
            bool IsInnerRail = false;

            for (int RailCounter = 1; RailCounter <= AmountOfRails; RailCounter++)
            {
                if (RailCounter == 1 || RailCounter == AmountOfRails)
                    Step = StepInOuterRail;
                else
                {
                    Step = GetFirstStepInInnerRail(AmountOfRails, RailCounter);
                    IsInnerRail = true;
                }

                StepPosition = PositionInDecodedLine;

                while (StepPosition < DecodedLine.Length)
                {
                    DecodedLine[StepPosition] = EncodedLine[PositionInEncodedLine].ToString();

                    PositionInEncodedLine++;
                    StepPosition = StepPosition + Step;

                    if (IsInnerRail)
                        Step = SumOfFirstAndSecondInnerSteps - Step;
                }

                PositionInDecodedLine++;
                IsInnerRail = false;
            }

            return string.Join("", DecodedLine);
        }

        static void Main(string[] args)
        {
            string TestLine = "WEAREDISCOVEREDFLEEATONCE";

            Console.WriteLine( EncodeMethod(3, TestLine));
            Console.WriteLine(DecodeMethod(3, "WECRLTEERDSOEEFEAOCAIVDEN"));

            Console.ReadKey();
        }
    }
}

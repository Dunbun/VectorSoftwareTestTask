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
                return String.Empty;
            if (LineToEncode.Length == 0)
                return LineToEncode;

            int stepInOuterRail = GetStepInOuterRail(AmountOfRails);
            int sumOfFirstAndSecondInnerSteps = GetSumOfFirstAndSecondInnerSteps(AmountOfRails);
            string [] encodedLine = new string[LineToEncode.Length];
            int stepPosition = 0;
            int positionInLineToEncode = 0;
            int positionInEncodedLine = 0;
            int step = 0;
            bool isInnerRail = false;
            
            for (int railCounter = 1; railCounter <= AmountOfRails; railCounter++)
            {
                if (railCounter == 1 || railCounter == AmountOfRails)
                    step = stepInOuterRail;
                else
                {
                    step = GetFirstStepInInnerRail(AmountOfRails, railCounter);
                    isInnerRail = true;
                }

                stepPosition = positionInLineToEncode;

                while (stepPosition < LineToEncode.Length)
                {
                    encodedLine[positionInEncodedLine] = LineToEncode[stepPosition].ToString();
                    positionInEncodedLine++;
                    stepPosition = stepPosition + step;

                    if (isInnerRail)      
                        step = sumOfFirstAndSecondInnerSteps - step;                                      
                }

                positionInLineToEncode++;
                isInnerRail = false;
            }
            
            return string.Join("",encodedLine);
        }

        static string DecodeMethod(int AmountOfRails, string EncodedLine)
        {
            if (AmountOfRails < 2)
                return String.Empty;
            if (EncodedLine.Length == 0)
                return EncodedLine;

            int stepInOuterRail = GetStepInOuterRail(AmountOfRails);
            int sumOfFirstAndSecondInnerSteps = GetSumOfFirstAndSecondInnerSteps(AmountOfRails);
            string[] decodedLine = new string[EncodedLine.Length];
            int stepPosition = 0;
            int positionInDecodedLine = 0;
            int positionInEncodedLine = 0;
            int step = 0;
            bool isInnerRail = false;

            for (int railCounter = 1; railCounter <= AmountOfRails; railCounter++)
            {
                if (railCounter == 1 || railCounter == AmountOfRails)
                    step = stepInOuterRail;
                else
                {
                    step = GetFirstStepInInnerRail(AmountOfRails, railCounter);
                    isInnerRail = true;
                }

                stepPosition = positionInDecodedLine;

                while (stepPosition < decodedLine.Length)
                {
                    decodedLine[stepPosition] = EncodedLine[positionInEncodedLine].ToString();

                    positionInEncodedLine++;
                    stepPosition = stepPosition + step;

                    if (isInnerRail)
                        step = sumOfFirstAndSecondInnerSteps - step;
                }

                positionInDecodedLine++;
                isInnerRail = false;
            }

            return string.Join("", decodedLine);
        }

        static void Main(string[] args)
        {
            string TestLine = "WEAREDISCOVEREDFLEEATONCE";

            Console.WriteLine(EncodeMethod(11, "WEAREDISCOVEREDFLEEATONCE"));
            Console.WriteLine(DecodeMethod(11, "WTEAOAENRECELEDFIDSECROEV"));

            Console.ReadKey();
        }
    }
}

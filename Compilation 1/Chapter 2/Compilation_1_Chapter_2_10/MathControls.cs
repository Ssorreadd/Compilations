using System;

namespace Compilation_1_Chapter_2_10
{
    public class MathControls
    {
        public MathControls(string value)
        {
            FirstDigit = int.Parse(value[0].ToString());
            SecondDigit = int.Parse(value[1].ToString());
        } 

        public int FirstDigit { get; private set; }

        public int SecondDigit { get; private set; }

        public int GetDecimals() => FirstDigit;

        public int GetUnits() => SecondDigit;

        public int GetSum() => FirstDigit + SecondDigit;

        public int GetMultiplication() => FirstDigit * SecondDigit;
    }
}

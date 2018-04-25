using System;
using System.Runtime.InteropServices;

namespace Calculator.Methods
{
    public class AsmProxy
    {
        [DllImport("Asm.dll")]
        public static extern float[] AsmAddition(float[] table1, float[] table2);

        [DllImport("Asm.dll")]
        public static extern float[] AsmSubstraction(float[] table1, float[] table2);

        [DllImport("Asm.dll")]
        public static extern float[] AsmMultiplication(float[] table1, float[] table2);

        [DllImport("Asm.dll")]
        public static extern float[] AsmDivision(float[] table1, float[] table2);

    }
}

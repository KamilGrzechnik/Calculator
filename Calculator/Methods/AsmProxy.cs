using System.Runtime.InteropServices;

namespace Calculator.Methods
{
    public class AsmProxy
    {
        [DllImport("Asm.dll")]
        private static extern float AsmAddVec(float a1, float a2, float a3, float a4, float b1, float b2, float b3, float b4);

        public double ExecuteAsmAddVec(float a1, float a2, float a3, float a4, float b1, float b2, float b3, float b4)
        {
            return AsmAddVec(a1, a2, a3, a4, b1, b2, b3, b4);
        }
    }
}

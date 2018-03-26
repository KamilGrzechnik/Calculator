using System;
using System.Collections.Generic;

namespace Calculator.Methods
{
    public class AssemblerHandler
    {
        private AsmProxy proxy;

        public AssemblerHandler()
        {
            proxy = new AsmProxy();
        }

        public List<float> Addition(List<float> floatList)
        {
            var list = new List<float>() { 1, 1, 1, 1 };
            return list;
        }

        public List<float> Substraction(List<float> floatList)
        {
            var list = new List<float>() { 2, 2, 2, 2 };
            return list;
        }

        public List<float> Multiplication(List<float> floatList)
        {
            var list = new List<float>() { 3, 3, 3, 3 };
            return list;
        }

        public List<float> Division(List<float> floatList)
        {
            var list = new List<float>() { 4, 4, 4, 4 };
            return list;
        }

    }
}

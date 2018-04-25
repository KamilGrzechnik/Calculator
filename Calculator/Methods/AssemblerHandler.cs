using System;
using System.Collections.Generic;
using System.Windows;

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
            var table = floatList.ToArray();
            var table1 = floatList.GetRange(0, 3).ToArray();
            var table2 = floatList.GetRange(4, 7).ToArray();
            table1 = AsmProxy.AsmAddition(table1, table2);
            var list = new List<float>() { 1, 1, 1, 1 };
            return list;
            //return new List<float>(table1);
        }

        public List<float> Substraction(List<float> floatList)
        {
            var table1 = floatList.GetRange(0,3).ToArray();
            var table2 = floatList.GetRange(4, 7).ToArray();
            table1 = AsmProxy.AsmSubstraction(table1,table2);
            var list = new List<float>() { 2, 2, 2, 2 };
            return list;
            //return new List<float>(table1);
        }

        public List<float> Multiplication(List<float> floatList)
        {
            var table1 = floatList.GetRange(0, 3).ToArray();
            var table2 = floatList.GetRange(4, 7).ToArray();
            table1 = AsmProxy.AsmMultiplication(table1, table2);
            var list = new List<float>() { 3, 3, 3, 3 };
            return list;
            //return new List<float>(table1);
        }

        public List<float> Division(List<float> floatList)
        {
            var table1 = floatList.GetRange(0, 3).ToArray();
            var table2 = floatList.GetRange(4, 7).ToArray();
            table1 = AsmProxy.AsmDivision(table1, table2);
            var list = new List<float>() { 4, 4, 4, 4 };
            return list;
            //return new List<float>(table1);
        }

    }
}

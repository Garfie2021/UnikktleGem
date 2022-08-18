using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SampleClass1 
    {
        public static void method1()
        {
            method2();

            SampleClassSt1.method1();
        }

        public static void method2()
        {
            throw new Exception("aaa");
        }
    }

    static class SampleClassSt1
    {
        public static void method1()
        {
        }

    }

}

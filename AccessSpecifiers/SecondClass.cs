using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    internal class SecondClass: Program
    {
        private void Test1()
        {
            Program s = new Program();
           // s.Test1();
            Console.WriteLine("Private Method");
        }

        //internal void Test2()
        //{
        //    Console.WriteLine("Internal Method");
        //}

        //protected void Test3()
        //{
        //    Console.WriteLine("Protected Method");
        //}

        //protected internal void Test4()
        //{
        //    Console.WriteLine("Protected  internal Method");
        //}

        //public void Test5()
        //{
        //    Console.WriteLine("Public Method");
        //}
    }
}

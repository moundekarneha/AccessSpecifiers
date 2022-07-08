using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    internal class Program 
    {
        //static variable - can modify - only one time life cycle - can innitialize within satic bloc - constructor
        static int j=20;
        //constant - it is initiallized only one time and doesnt requires instance of class-not modified
        const float pi = 3.14f;
        //readonly - can not modified once it is initialize - it is not compulsary to initialize at the time of declaration - we can initialize within constructor
        readonly int readdata;
        public Program()
        {
            readdata = 10;
        } 

        private void Test1()
        {
            Console.WriteLine("Private Method");
        }

        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }

        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }

        protected internal void Test4()
        {
            Console.WriteLine("Protected  internal Method");
        }

        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            
            int yy=120; //static variable - bcoz it is inside to static block 
            Console.WriteLine("----------------Method of First class------------------------");
            Program p = new Program();
            p.Test1();
            p.Test2();
            p.Test3();
            p.Test4();
            p.Test5();


            Console.WriteLine("----------------Method of Second class------------------------");
            SecondClass s = new SecondClass();
            s.Test1(); // private
            s.Test2();
            s.Test3(); //protected
            s.Test4();
            s.Test5();


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Assembly1
{
    public class Assembly1BaseClass
    {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedInternalVariable = "protected internal";
        public string publicVariable = "public";
    

        public void TestAccess()
        {
            //Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);

        }


    }
    public class Assembly1DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            //Not Accessible
            //Console.WriteLine(privateVariable);
            
            //Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }
    public class Assembly1OtherClass
    {
        public void TestAccess()
        {
            Assembly1BaseClass objBaseClass = new Assembly1BaseClass();
            //Not accessible
            //Console.WriteLine(objBaseClass.privateVariable);
            //Console.WriteLine(objBaseClass.protectedVariable);
            Console.WriteLine(objBaseClass.internalVariable);
            Console.WriteLine(objBaseClass.protectedInternalVariable);
            Console.WriteLine(objBaseClass.publicVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly1BaseClass objBase = new Assembly1BaseClass();
            //objBase.TestAccess();
            //Assembly1DerivedClass derivedClass = new Assembly1DerivedClass();
            //derivedClass.TestAccessInDerivedClass();
            Assembly1OtherClass otherClass = new Assembly1OtherClass();
            otherClass.TestAccess();
            Console.ReadKey();
        }
    }
}

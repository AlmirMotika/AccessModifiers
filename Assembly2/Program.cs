using System;
using System.Collections.Generic;
using System.Text;
using Assembly1;

namespace Assembly2
{
    public class Assembly2DerivedClass : Assembly1BaseClass
    {
        public void TestAccessInDerivedClass()
        {
            //Not accesible
            //Console.WriteLine(privateVariable);
            // Console.WriteLine(internalVariable);

            //Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(protectedInternalVariable);
            Console.WriteLine(publicVariable);
        }
    }
    public class Assembly2OtherClass
    {
        public void TestAccess()
        {
            Assembly1BaseClass objBaseClass = new Assembly1BaseClass();
            //Not accessible
            //Console.WriteLine(objBaseClass.privateVariable);
            //Console.WriteLine(objBaseClass.protectedVariable);
            //Console.WriteLine(objBaseClass.internalVariable);
            //Console.WriteLine(objBaseClass.protectedInternalVariable);

            //Accessible
            Console.WriteLine(objBaseClass.publicVariable);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly2DerivedClass obj = new Assembly2DerivedClass();
            //obj.TestAccessInDerivedClass();

            //obj.TestAccess();

            Assembly2OtherClass objOtherClass = new Assembly2OtherClass();

            objOtherClass.TestAccess();
            Console.ReadKey();
        }
    }
}

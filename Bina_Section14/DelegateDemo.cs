using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
delegate void Procedure();//declare delegate 
public delegate int PerformCalulation(int x, int y);


namespace Bina_Section14
{
    internal class DelegateDemo
    {
        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static void Method2()
        {
            Console.WriteLine("Method2");
        }
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public int Method4(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
            
;       }
        public int Method5(int a, int b)
        {
            int result = a * b;
            Console.WriteLine(result);
            return result;
            
        }

        public int Method6 (int a, int b)
        {
            int result = a * b;           
            return result;

        }


        public static void Main()
        {
            Procedure someProcs = null;//instantiating delgate
          

            //Method 1 and Method 2 are static
            //so we don't need instacne of an object to access them

            someProcs += new Procedure(DelegateDemo.Method1);
            someProcs += new Procedure(Method2);// Example with omitted class name          

            //Method 3 is not static
            //so need instance of Delegatedemo so we can use that object reference to attach that method
            
            DelegateDemo demo = new DelegateDemo();
            someProcs += new Procedure(demo.Method3);
            someProcs();

            PerformCalulation calc = null;//instantiating perform calculating delgate

            calc += new PerformCalulation(demo.Method4);        
            calc = new PerformCalulation(demo.Method5);

            calc(1, 2);


        }
    }
}

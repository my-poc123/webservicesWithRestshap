using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.templatemethod
{
    class ConcretClass1 : AbstractTemplateMethod
    {
        private string v1;
        private int v2;

        public ConcretClass1(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1 "+ v1);
        }

        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2" + v2);
        }

        protected override void Hook2()
        {
            Console.WriteLine("This is a Hook2: " + v1 + v2);
        }
    }
}

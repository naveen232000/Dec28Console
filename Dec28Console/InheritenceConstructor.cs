using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28Console
{
    public class InheritenceConstructor
    {
        public InheritenceConstructor() 
        {
            Console.WriteLine("I am from Parent NoParameter Constructor \n ");
        }
        public InheritenceConstructor(int a,int b)
        {
            Console.WriteLine("I am from Parent Parameter Constructor => my sum is :" +(a+b));
        }
        static InheritenceConstructor()
        {
            Console.WriteLine("I am from Parent Static Constructor" );
        }
    }
    public class MyChild:InheritenceConstructor
    {
        public MyChild()
        {
            Console.WriteLine("I am from Child NoParameter Constructor \n ");
        }
        public MyChild(int a, int b) : base(5,5)
        {
            Console.WriteLine("I am from child Parameter Constructor => my sum is :" + (a + b));
        }
        static MyChild()
        {
            Console.WriteLine("I am from Child Static Constructor");
        }
        static void Main(string[] args)
        {
            MyChild myChild = new MyChild();
            MyChild myChild2 = new MyChild(2,2);
           Console.ReadLine();
        }
    }
}

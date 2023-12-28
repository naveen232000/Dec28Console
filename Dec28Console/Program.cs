using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec28Console
{
    //Inheritence example
    public class Parent
    {
        public void Parent1() {
            Console.WriteLine("From Parent public");
        }
        private void Parent2(int a) {
            Console.WriteLine("Private parent Constractor " + a);
        }
        protected void Parent3(int a,int b)
        {
            Console.WriteLine("Protected parent constructor " + (a+6));
        }
    }
    public class Program :Parent
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Parent1();
            program.Parent3(2,3);
            /*can able to access
              prtected and public method
              through child class object in the child class main method*/
            Parent parent = new Parent();
            parent.Parent1();
                /*can't able to access
               prtected and private method
               inside the child class main method*/
            Console.ReadLine();
        }
    }
}

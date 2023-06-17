using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_programs
{
    public class Oops // created class with public access modifier// base class
    {
        public void createObject() // public void method
        {
            string name = "Ajay"; // create a string variable with value
            int number = 10;
            double value = 10.5455;
            bool say = false;
            char letter = 'A';
            Console.WriteLine("Created the class and object "+name);
        }
    }

    public class inheritance : Oops //derived class// inherit from the base class Oops
    {
        public string lastname = "Chandra"; // instance
    }

    public class Polymorphism1
    {
        public static void method() // static method
        {
            Console.WriteLine("Main Class");
        }
    }

    public class Poly2 : Polymorphism1 // inherit from Polymorphism1 class to child class Poly2
    {
        public virtual void method() // virtual method for method overriding
        {
            Console.WriteLine("Polyclass");
        }
    }

    class Ploy3 : Poly2
    {
        public override void method() // overridden method
        {
            Console.WriteLine("This is override method");
        }
    }

    abstract class Name
    {
        public abstract void method1();

        public static void method2()
        {
            Console.WriteLine("Abstraction");
        }
    }

    class Name1 : Name
    {
        public override void method1()
        {
            Console.WriteLine("Overridden");
        }
    }

    interface Iname 
    {
        public void method3(int number2);
    }
    interface Iname1
    {
        void method4();
    }

    class interfacess : Iname,Iname1
    {
        int number = 20; //value type
        public int number2;
        public void method3(int number2)
        {
            this.number2= number2; // reference type
            Console.WriteLine("interface method3");
        }

        public void method4()
        {
            Console.WriteLine("interface method 4");
        }
    }

    class modifiers
    {
        public int number = 10; // can access anywhere
        private int number2;// can access only inside the same class
        protected int number3 = 30; // can access only same class as well as the inherited class


        public modifiers( int number2) //constructor and parameterized constructor
        {
            this.number2 = number2;
            Console.WriteLine(number+number2);
        }
    }
}

using System.Threading.Tasks.Dataflow;
using OOPS_programs;
namespace OOPS_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oops Concepts \n");

            Oops objects = new Oops(); // create object // because of it is non static method
            objects.createObject();
            Console.WriteLine(objects.createObject);
            //inheritance
            inheritance obj = new inheritance();
            obj.createObject();
            Console.WriteLine(obj.lastname);
            //Polymorphism
            Polymorphism1.method();
            Poly2 obj3 = new Ploy3();
            obj3.method();
           // Abstraction
            Name1 name1= new Name1();
            name1.method1();
            Name1.method2();
            //interfaces 
            interfacess obj5= new interfacess();
            obj5.method3(5);
            obj5.method4();
            
        }
    }
}
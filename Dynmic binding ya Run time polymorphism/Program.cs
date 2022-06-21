using System;

namespace Dynmic_binding_ya_Run_time_polymorphism
{

    class MyClass
    {
        public  virtual void show()
        {
            Console.WriteLine("Hello :");
        }
    }


    class Program : MyClass
    {
        public override void show()
        {
            Console.WriteLine("Hii :");
        }
        static void Main(string[] args)
        {
         MyClass obj = new Program();
            obj.show();
        }
    }
}

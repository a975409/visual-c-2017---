using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 實例81
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Cat();
            Animal a2 = new Rabbit();
            Animal a3 = new Dog();

            Console.WriteLine($"這隻寵物是：{a1.Name}");
            Console.WriteLine($"這隻寵物是：{a2.Name}");
            Console.WriteLine($"這隻寵物是：{a3.Name}");
            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; }
    }

    class Cat : Animal
    {
        public override string Name => "貓咪";
    }

    class Rabbit : Animal
    {
        public override string Name => "兔子";
    }

    class Dog : Animal
    {
        public override string Name => "狗";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternStrategy
{
    class Program
    {
        public interface IFly
        {
            void Fly();
        }
        public class FlyFast : IFly
        {
            public void Fly()
            {
                Console.WriteLine("This duck flies fast");
            }
        }
        public class FlySlowly : IFly
        {
            public void Fly()
            {
                Console.WriteLine("This duck is flying slowly");
            }
        }
        public interface IQuack
        {
            void Quack();
        }
        public class QuackLoudly : IQuack
        {
            public void Quack()
            {
                Console.WriteLine("This duck quacks loudly");
            }
        }
        public class QuackSoftly : IQuack
        {
            public void Quack()
            {
                Console.WriteLine("This duck quacks softly");
            }
        }

        public class Duck
        {
            protected IFly varFlying;
            protected IQuack varQuacking;

            public IFly fly
            {
                set
                {
                    varFlying = value;
                }
                get
                {
                    return varFlying;
                }
            }
            public IQuack quack
            {
                set
                {
                    varQuacking = value;
                }
                get
                {
                    return varQuacking;
                }
            }

            public void ExecuteFly()
            {
                fly.Fly();
            }
            public void ExecuteQuack()
            {
                quack.Quack();
            }

            protected virtual void Swim()
            {
                Console.WriteLine("This duck swims");
            }
        }

        public class WildDuck : Duck
        {
            public WildDuck()
            {
                fly = new FlyFast();
                quack = new QuackSoftly();
            }
        }

        public class HomeDuck : Duck
        {
            public HomeDuck()
            {
                fly = new FlySlowly();
                quack = new QuackSoftly();
            }
        }
        public class RabberDuck : Duck
        {
            public RabberDuck()
            {
                
            }
        }
        static void Main(string[] args)
        {
            HomeDuck homeduck=new HomeDuck();
            WildDuck wildduck = new WildDuck();
            homeduck.ExecuteFly();
            homeduck.ExecuteQuack();
            homeduck.fly = new FlyFast();
            homeduck.ExecuteFly();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    // This principle is just an extension of the Open Close Principle.
    //It means that we must make sure that new derived classes are extending the base classes without changing their behavior.
    //LSP states that the derived classes should be perfectly substitutable for their base classes. If class D is derived from A then D should be substitutable for A.

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());
        }
    }


    public abstract class Fruit
    {
        public abstract string GetColor();
    }

    public class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }

}

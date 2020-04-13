using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingProblems.StackOverflowProblem
{
    public class StackOverflowMain
    {
    }

    public class FooAttributeCollection
    {
        public FooAttributeCollection(Foo owner)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public abstract class Foo
    {
        private readonly FooAttributeCollection attributes;

        public Foo(FooAttributeCollection attributes)
        {
            this.attributes = attributes;
        }
    }

    public class Bar : Foo
    {
        public Bar(FooAttributeCollection attributes) : base(attributes)
        {
        }
    }
}

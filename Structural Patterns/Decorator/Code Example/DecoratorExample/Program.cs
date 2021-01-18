using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator...");

            IComponent baseComponent = new Component();

            // Case 1 : No decorator and only the base IComponent
            Display("1. Basic Component : ", baseComponent);

            // Case 2 : Decorated with the basic decorator
            Display("2. Decorated with the basic Decorator : ", new Decorator(baseComponent));

            // Case 3 : Decorated with the complex decorator
            Display("3. Decorated with the Complex Decorator : ", new DecoratorWithNewStateAndOperation(baseComponent));

            // Case 4 : Nested Decoration
            Display("4. Nested Decoration : ", new DecoratorWithNewStateAndOperation(new Decorator(baseComponent)));

            // Case 5 : Simple - Complex Decoration
            DecoratorWithNewStateAndOperation dComplex = new DecoratorWithNewStateAndOperation(new Component());
            Decorator dSimple = new Decorator(dComplex);
            Display("5. Simple to Complex Decoration : ", dSimple);

            // Case 6 : Added State and Behaviour
            Console.WriteLine("Added state : " + dComplex.AddedState + "\tAdded Behaviour : " + dComplex.AddedBehaviour());
        }

        /// <summary>
        /// Display operation
        /// </summary>
        /// <param name="s"> string </param>
        /// <param name="component"> component </param>
        static void Display(string s, IComponent component)
        {
            Console.WriteLine(s + component.Operation());
        }
    }
}

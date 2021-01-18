using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    internal class Component : IComponent
    {
        public Component()
        {
            // default constructor
        }

        /// <summary>
        /// Operation
        /// </summary>
        /// <returns> a string </returns>
        public string Operation()
        {
            return "Invoked the Operation in the Original Component...";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorExample
{
    internal class DecoratorWithNewStateAndOperation : IComponent
    {
        /// <summary>
        /// IComponent Instance
        /// </summary>
        IComponent Component;

        /// <summary>
        /// Added state
        /// </summary>
        public string AddedState = "State added in the second Decorator...";

        public DecoratorWithNewStateAndOperation(IComponent c)
        {
            Component = c;
        }


        public string Operation()
        {
            string s = Component.Operation();
            s += "Invoked from the Second Decorator...";

            return s;
        }

        /// <summary>
        /// added behaviour
        /// </summary>
        /// <returns> new string </returns>
        public string AddedBehaviour()
        {
            return "New Behaviour added in the second decorator...";
        }
    }
}

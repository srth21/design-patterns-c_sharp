namespace DecoratorExample
{
    internal class Decorator : IComponent
    {
        /// <summary>
        /// Original component instance 
        /// </summary>
        IComponent Component;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="component"></param>
        public Decorator(IComponent component)
        {
            Component = component;
        }

        /// <summary>
        /// adding some decoration to the original Operation from the component
        /// </summary>
        /// <returns> decorated string </returns>
        public string Operation()
        {
            string s = Component.Operation();
            return s + " Invoked from the Decorator...";
        }
    }
}

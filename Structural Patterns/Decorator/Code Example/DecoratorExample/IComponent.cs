namespace DecoratorExample
{
    using System;

    internal interface IComponent
    {
        /// <summary>
        /// Operation that returns a string
        /// </summary>
        /// <returns> a string </returns>
        string Operation();
    }
}

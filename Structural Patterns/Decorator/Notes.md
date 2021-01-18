Decorator Pattern : Structural Pattern.

ROLE
- The role of a decorator pattern is to provide a way to dynamically add state and behaviour to an existing object.
- The underlying object does not know that a state is being added to it or that it is being decorated.

Features
- The original object is unaware of the decoration
- There is no one big feature class with all the options in it
- The decorations are independent of each other
- The decorations can be composed together in a mix and match fashion

Illustration
- Decorator pattern takes an existing object and then adds to it.

Design
- There are 4 components in the design for Decorator
    1. IComponent : The interface that defines the functionality and state for an object which has to be decorated.
    2. Component : An original class that can have operations added to it. The class to which the object to be decorated belongs.
    3. Operation : An operation in the IComponent class that can be replaced
    4. Decorator : A class that adds behaviour and/or state to the component. This also implements the IComponent Interface.

Key relationships : 
    - Given that the Decorator implements the IComponent interface, they can be used wherever the Component Objects were used.
        - This fact that the client can use the Decorator and the Component Objects interchangably is the heart of the Decorator pattern.
    - Has a Relationship
        - The decorator and the IComponent have a "has a relationship" indicating that the decorator instantiates one or more IComponent Objects.
            - This goes on to say that the decorator can invoke the component attribute to invoke any method it may wish to override.

Good to know points : 
    - There are two more parts in the Decorator : 
        - addedBehaviour and addedState : these two are ways of extending the original behavior of the component.

    - Each Decorator contains a IComponent Interface object. 
        - This could be a component or in turn another decorator. 
        - Thus decorators can be nested.    
    
    - Decorators can either add a new Operation to the component or replace/override an existing operation.

    - Decorators do not rely on Inheritance for extending behaviour as this would make the classes overweight.

.\Code Example contains a simple example implementing these 4 pieces.
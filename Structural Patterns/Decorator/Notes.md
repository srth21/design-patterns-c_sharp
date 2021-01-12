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
    
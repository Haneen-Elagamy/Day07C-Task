using System;

namespace Day07C_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problems

            #region problem_1
            //Car MyCar;
            //MyCar = new Car();//default Ctor
            //Console.WriteLine(MyCar.ToString());

            //MyCar=new Car(1);//Constructor with one parameter (Id).
            //Console.WriteLine(MyCar.ToString());

            //MyCar =new Car(2,"KIA"); //Constructor with two parameters(Id, Brand).
            //Console.WriteLine(MyCar.ToString());

            //MyCar =new Car(3,"BMW",10000000M); //Constructor with all three parameters.
            //Console.WriteLine(MyCar.ToString()); 
            #endregion

            #region problem_2
            //Calculator Calc;
            //Calc=new Calculator();

            //// Test the methods
            //Console.WriteLine("Sum of two integers: " + Calc.Sum(10, 20));               
            //Console.WriteLine("Sum of three integers: " + Calc.Sum(10, 20, 30));         
            //Console.WriteLine("Sum of two doubles: " + Calc.Sum(10.5, 20.3));            

            #endregion

            #region problem_4
            //Parent parent = new Parent (3,4);
            //Console.WriteLine("Parent Product: " + parent.Product()); // Outputs 12

            //Parent childAsParentNew = new Child(3,4,5);
            //Console.WriteLine("ChildUsingNew (as Parent) Product: " + childAsParentNew.Product()); // Outputs 12 parent's method

            //Child ChildNew = new Child(3,4,5);
            //Console.WriteLine("ChildUsingNew Product:"+ChildNew.Product()); //Outputs 60 Child's method

            //Parent childAsParentOverride = new Child2(3,4,2);
            //Console.WriteLine("ChildUsingOverride (as Parent) Product: " + childAsParentOverride.Product()); // Outputs 14 (Child's method)

            //Child2 childOverride = new Child2 (3,4,2);
            //Console.WriteLine("ChildUsingOverride Product: " + childOverride.Product()); // Outputs 14 (Child's method) 
            #endregion

            #region problem_5
            //Parent parent =new Parent(2,5);
            //Console.WriteLine(parent.ToString());

            //Child child = new Child(2,5,10);
            //Console.WriteLine(child.ToString()); 
            #endregion

            #region problem_6
            //Rectangle rectangle = new Rectangle { Length=10,Width=20};

            //Console.WriteLine($"Rectangle Area:{rectangle.Area}");

            //rectangle.Draw(); 
            #endregion

            #region problem_7
            //IShap circle = new Circle();
            //circle.PrintDetails(); 
            #endregion

            #region problem_8
            //IMovable car= new Car();
            //car.Move(); 
            #endregion

            #region problem_9
            //File file = new File { Name = "Haneen" };
            //file.Read();
            //file.Write(); 
            #endregion

            #region problem_10
            //Rectangle2 rectangle = new Rectangle2 { Length = 10, Width = 20 };

            //rectangle.Draw();

            //Console.WriteLine($"Area of Rectangle: {rectangle.CalculateArea()}"); 
            #endregion

            #endregion

            #region Questions
            #region Q1
            //Question: Why does defining a custom constructor suppress the default constructor in C#?

            /*In C#, when you define a **custom constructor**, the **default constructor** (parameterless constructor) is suppressed 
             * because the compiler assumes that the custom constructor provides the necessary logic to initialize the object. 

             The **default constructor** is automatically provided by the compiler only when no constructors are explicitly
            defined in the class or struct. Once a custom constructor is added, the default one is no longer automatically
            created to avoid conflicting initialization logic.

            If you still need a parameterless constructor alongside custom constructors, you must define it explicitly. 

            This design enforces control over object initialization and prevents unintended or inconsistent states in objects.*/
            #endregion

            #region Q2

            //Question: How does method overloading improve code readability and reusability?

            /*Unified Naming:
             Instead of using multiple method names for similar tasks, a single method name with different 
              parameters can be used. This makes the code easier to read and understand.

             2-Enhanced Code Clarity:
              Developers can quickly identify related functionalities under the same method name, avoiding 
              confusion and improving the structure of the code.

            3-Reusability of Logic:
             Overloading allows using the same method logic for different data types or input scenarios,
             reducing the need to write duplicate code.

            4-Flexibility:
              It provides the flexibility to handle various use cases with a single method name, which can adapt 
             to different numbers or types of arguments.

            5-Simplified Maintenance:
             Overloaded methods are easier to update or modify since related operations are encapsulated 
            within the same method name.
            Example: A single Sum() method in a Calculator class can handle integers, doubles, and multiple arguments,
            making the code more intuitive and reusable without creating separate methods like SumIntegers() or SumDoubles().*/
            #endregion

            #region Q3
            //Question: What is the purpose of constructor chaining in inheritance?

            /*Initialization of Base Class Members:
            It ensures that all fields and properties of the base class are initialized before the derived class adds 
            its own members, maintaining consistency and avoiding uninitialized values.

            Code Reusability:
             By chaining constructors, common initialization logic in the base class can be reused instead 
              of being re-implemented in derived classes.

             Proper Object Construction:
             It ensures the object is fully constructed from the base class to the most derived class, following the principle
             of constructing objects from top to bottom in the inheritance hierarchy.

            Readability and Maintainability:
            It provides a clear and structured way to manage constructor calls, especially when dealing with complex inheritance hierarchies.

            Example Purpose: If a base class Person initializes attributes like Name and Age, a derived class Student can use constructor 
            chaining to inherit and extend this functionality by adding attributes like Grade.
            */
            #endregion

            #region Q4
            //Question: How does new differ from override in method overriding?

            /*new (Hiding):
             When you use new, the method in the child class hides the method in the parent class.
            The choice of which method to call depends on the reference type (Parent or Child) at
            compile-time, not the actual object type at runtime.
            This means that if you access a child object through a parent reference, the parent’s
             version of the method is called.

            override (Overriding):
            When you use override, the method in the child class overrides the parent’s version,
            enabling runtime polymorphism.
            This means the method that gets executed is determined at runtime based on the actual 
            object type, regardless of the reference type.*/
            #endregion

            #region Q5
            //Question: Why is ToString() often overridden in custom classes?

            /*Improved Readability: By default, the ToString() method returns the fully qualified name of the class (e.g., Namespace.ClassName). Overriding it
             * allows you to return a more meaningful string representation of the object, making it easier to read and understand when printed or logged.

             Enhanced Debugging: Customizing ToString() can provide a concise summary of an object’s state, which is helpful during debugging. When you log 
            or inspect objects, having a well-defined string output can help you quickly identify key properties and their values.

            String Representation: By overriding ToString(), you can decide how the class should be represented as a string, such as showing key properties or
            the object’s internal state. This can be useful for displaying information in user interfaces or logging outputs.

            In summary, overriding ToString() allows for better control over how objects are represented as strings, improving code clarity, debugging, and data visualization.*/

            #endregion

            #region Q6
            //Question: Why can't you create an instance of an interface directly?

            /*You cannot create an instance of an interface directly because an interface is an abstract type. It only defines a contract that specifies 
             * what methods and properties a class or struct must implement but does not provide any implementation details itself.
             * Here's a concise explanation:

             No Implementation:
              Interfaces only declare method signatures and properties without providing their functionality.
              Since there is no actual code to execute, creating an instance of an interface would lead to a runtime error.

            Purpose of Interfaces:
            Interfaces are meant to establish a contract for classes or structs to follow. They are not designed
             to represent concrete behavior but to define a shared behavior across multiple types.

            Polymorphism:
            By using interfaces, you can write flexible, reusable code that works with any object implementing the interface, without needing to know the specific type.*/
            #endregion

            #region Q7
            //Question: What are the benefits of default implementations in interfaces introduced in C# 8.0?

            /*Backward Compatibility: New methods can be added to interfaces without breaking existing implementations.
            Code Reusability: Shared logic can be written once in the interface, reducing duplication.
            Reduced Boilerplate Code: Implementing classes only need to override methods requiring customization.
            Improved API Design: Interfaces can evolve without introducing breaking changes.
            Simplified Maintenance: Centralized logic in the interface makes updates easier.
            Support for Mixins: Enables multiple inheritance of behavior without losing interface flexibility.*/

            #endregion

            #region Q8
            //Question: Why is it useful to use an interface reference to access implementing class methods?

            /*Decoupling: Allows code to depend on abstractions rather than specific implementations, making the code more flexible and easier to maintain.
             Polymorphism: Enables treating different implementing classes uniformly, allowing the same interface reference to handle multiple types.
             Scalability: Simplifies adding new implementations, as existing code can interact with them via the interface without changes.
             Interchangeability: Makes it easy to swap out implementations, such as replacing a mock class with a real one during testing.
              Extensibility: Promotes writing generic and reusable code by relying on the interface instead of concrete types.*/

            #endregion

            #region Q9
            //Question: How does C# overcome the limitation of single inheritance with interfaces?

            /*C# overcomes the limitation of single inheritance by allowing a class to implement multiple interfaces. While a class can inherit from only one base class, 
             * it can implement any number of interfaces, enabling it to adhere to multiple contracts and provide diverse functionalities.

           Key Points:
           Multiple Contracts: A class can conform to multiple behaviors defined by interfaces, which is not possible with single inheritance.
           Flexible Design: Interfaces allow combining behaviors from various sources without creating deep inheritance hierarchies.
           Conflict Resolution: Explicit interface implementation resolves member name conflicts when multiple interfaces define the same members.*/
            #endregion

            #region Q10
            //Question: What is the difference between a virtual method and an abstract method in C#?

            /*A virtual method in C# is a method that has an implementation in the base class but allows derived classes to override it 
             * and provide their own implementation. On the other hand, an abstract method is declared in an abstract class and does not
             * have an implementation; derived classes are required to implement it.

             Virtual Method:
               It provides a default behavior in the base class, which can optionally be overridden in derived classes.
               It is defined using the virtual keyword.
               Derived classes can use the override keyword to modify the behavior or choose not to override it and use the base class implementation.

             Abstract Method:
              It is only declared in the base class with no body or implementation, serving as a contract.
              It must be defined in an abstract class and is marked with the abstract keyword.
              Derived classes are required to implement it; otherwise, the compiler will throw an error.*/
            #endregion 
            #endregion



        }
    }


}

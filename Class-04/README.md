# ![cf](http://i.imgur.com/7v5ASc8.png) Class 04

## Overview:
1. We are shifting gears this day away from the basic syntax of the langauge, more into the actual OOP side of C#. 
1. Today we will be introducing what a class is and how it is different than an object. 
3. We introduce two of the four OOP principles: Inheritance and Abstraction

## Learning Objectives
1. The Student will understand the basic coponents of a class
2. The student will know how to instantiate an object and how it is different from a class
1. The Student will be introduced to the Object Oriented Pillars and know how and when to identify inheritance and abstraction behavior.
## Lecture Outline


### **Introduction to Classes**
   1. **What is a Class?**
      1. A class is a 'blueprint' it defines the data and behavior of a type. 
      1. non-static classes can be used to create objects or instances which can be assigned to variables.
      1. if declared static, then only one copy exists in memory and client code can only access it the the class itself.
         1. static classes can only be referenced through their methods (i.e. Math class, the methods are used to operate on input paramaters: `Math.Round(double)`, `Math.Floor`)
      1. ***class defines a tpe of object, but is not an object itself***
   

   1. **What is an Object?**
      1. ***An object is a concrete entity based on a class, and is referred to as an instance of a class***
      1. Use the `new` keyword to create an object
        ```csharp
        Customer amanda = new Customer();
        ```
      1. When an instance of a class is created, a reference to the object is created
      1. 'amanda' is a refernece to an object based on `Customer`. 

         - not reccomended - it will fail at runtime. (below)
            ```csharp
            //Create an object reference without creating an object
            Customer josie;
            ```

   - You can creates two object references that both refer to the same object. 
   - you *can* create an object reference and assigning it to an existing object 

   ```csharp
        Customer belle = new Customer();
        Customer kitty = belle;
   ```
   - ***Because objects that are based on classes are referred to by reference, classes are known as reference types***

   1. What are constructors?
      1. A constructor is defined like a method, except that the method name and return type are reduced to the name of the enclosing type:
      1. Constructors enable the programmer to set default values, limit instantiation, and write code that is flexible and easy to read.
      1. **Default Constructors**
         - if you don't provide a constructor, one is automatically made for you that sets the member variables to their default values
         - Syntax
            ```csharp
            public class Person
            {
               private string last;
               private string first;
   
               public Person(string lastName, string firstName)
               {
                  last = lastName;
                  first = firstName;
               }
   
               // Remaining implementation of Person class.
            }
            ```

    1. Object Initializers

```csharp
public class Bunny
{
  public string Name;
  public bool LikesCarrots;
  public bool LikesHumans;

  public Bunny () {}
  public Bunny (string n) { Name = n; }
}


// Using object initializers, you can instantiate Bunny objects as follows:
// Note parameterless constructors can omit empty parentheses
Bunny b1 = new Bunny { Name="Bo", LikesCarrots=true, LikesHumans=false };
Bunny b2 = new Bunny ("Bo")     { LikesCarrots=true, LikesHumans=false };

```

   1. What are properties?
        1. Properties look like fields from the outside, but internally they contain logic, like methods do.
        1. A property is declared like a field, but with a get/set block added
        1. A `get` property accessor is used to return the property value, and a `set` property accessor is used to assign a new value.
        2. The value keyword is used to define the value being assigned by the `set` accessor.
        3. Properties can be read-write (they have both a `get` and a `set` accessor), read-only (they have a `get` accessor but no `set` accessor), or write-only (they have a `set` accessor, but no `get` accessor). Write-only properties are rare and are most commonly used to restrict access to sensitive data.
    
        ```csharp
        class Person
        {
            private string name;  // the name field (called a 'backing store' note how it is private)
            public string Name    // the Name property
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
        }

        Person person = new Person();
        person.Name = "Joe";  // the set accessor is invoked here                

        System.Console.Write(person.Name);  // the get accessor is invoked here
        ```

        1. Logic can exist in the Get/Set accessors. 
         - This is OK
            ```csharp
            public class Date
            {
                private int month = 7;  // Backing store

                public int Month
                {
                    get
                    {
                        return month;
                    }
                    set
                    {
                        if ((value > 0) && (value < 13))
                        {
                            month = value;
                        }
                    }
                }
            }
            ```

      - So is this:

        ```csharp
        class Employee
        {
            private string name;
            public string Name
            {
                get
                {
                    return name != null ? name : "NA";
                }
            }
        }
        ```

        ***This is NOT good practice:***

        ```csharp
        private int number;
        public int Number
        {
            get
            {
                return number++;   // Don't do this
            }
        }
        ```

   1. OOPs Principles Pt.1 
      1. Inheritance
         - What is Inheritance?
           - Enables you to create new classes that reuse, extend, and modify the behavior in other classes
           - Base Class: class whose members are inherited (Animals is the base class of Cat)
           - Derived Class: class that inherits those members (i.e. Cat is derived from Animals)

      1. Abstraction
        
         1 ***Abstract Classes***: You can declare a `class` as abstract if you want to prevent direct instantiation by using hte `new` keyword. 
               - abstract class cannot be instantiated. The purpose of an abstrct class is to provide a ***common definition*** of a base class that multiple derived classes can share. 
               - An abstract class **may** have abstract methods, and virtual methods. (althogh an abstract class with abstr methods only might as well be an interface)
         1. Abstract: method **must** be overridden in any non-abstract class that directly inherits from that class. 

         1. Sealed Classes and Class Members
            - classes can be declared as sealed by putting in the keyword `sealed` before the class definiton. 

            ```csharp
            public sealed class MyClass
            {
                //class members here
            }
            ```
        - Sealed classes cannot be base class or abstract classes
        - Sealed classes prevent derivation
        - If you do not want a derived class to be able to override your method, then `seal it`
            ```csharp 
            public sealed override void DoWork(){}
            ```  
        - This method is override its base class DoWork(), as well as preventing any classes that derive from this class from overriding it. 

## Readings
- [Inheritance](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/inheritance)
- [Abstract](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members)
- [Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
- [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)

## Code Challenge 4
1. Complete [this tutorial](https://www.codecademy.com/courses/big-o/0/1) on the Big O notation.
1. Complete all 15 lessons within this tutorial. 
1. Submit a screenshot of the coding academy lesson overview with the checkmarks next to each completed lesson.

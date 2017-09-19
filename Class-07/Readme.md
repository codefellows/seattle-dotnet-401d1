![cf](http://i.imgur.com/7v5ASc8.png) Lab 7 : Collections
=====================================

## Learning Objectives
1.The student will understand and implement their own enums into their programs and classes.
1. The student will be able to identify and implement their own generic collection.
 
## Lecture Outline

### Enums

1. What are enums?
 

   - You can create and set your custom values

        ```csharp
            enum MachineState
            {
                PowerOff = 0,
                Running = 5,
                Sleeping = 10,
                Hibernating = Sleeping + 5
            }

            ```

### Collections

There are two ways to crate and manage a group of related objects
    1. Create an array of objects
    2. creating a collection of objects

1. What is a collection?

2. If your collection contains elements of only one data type, you can use a Generic. 

#### Generics
   1. One type of generic collection is a List<.T>; 
   2. Example of a List:

        ```csharp 
        var princesses = new List<string>();

        princesses.Add("Snow White");
        princesses.Add("Cinderella");
        princesses.Add("Aurora");
        princesses.Add("Repunzel");
        princesses.Add("Ariel");

        foreach(var princess in princesses)
        {
            Console.WriteLine($"Princess: {princess}");
        }


        ```


1. For the type of elements in the List< T>, you can also define your own class

     ```csharp
        private static void IterateThroughList()  
        {  
            var snowWhiteDwarves = new List<Dwarves>  
                {  
                    new Disney() { Name="Doc", age=400},  
                    new Disney() { Name="Happy", age=25},  
                    new Disney() { Name="Dopey", age=100},  
                    new Disney() { Name="Grumpy", age=53}  
                };  

            foreach (Disney dwarf in snowWhiteDwarves)  
            {  
                Console.WriteLine(snowWhiteDwarves.Name + "  " + snowWhiteDwarves.Age);  
            }  

        }  

        public class Disney  
        {  
            public string Name { get; set; }  
            public int age { get; set; }  
        }  

        ```


  - What is `GetEnumerator()`?
      - You need your class iterate through with a for loop. 

- Foreach does not requires Ienumerable
- only requires a Ienumerator GetEnumerator();

- *Enumerable* - means it can be iterated through
- *Enumerator* - that actual 'thing' that walkthroughs and sequences through the list



**Yield Return**

-You use a `yield return` statement to return each element one at a time.
- 'pauses' and returns the next value

**Yield Break**

You use a `yield break` statement to end an iteration
    -Clean way to end a loop from executing

**There is much more to `yield return` and `yield break` then what we may go over. 
  - if there is time in class we can go over the details of whats 'under the hood' 
   of the `yield` statements, or just direct the student to do some self research on it. 



### Generics vs. Non-Generics

#### Generics
- List< T>
- Dictionary< T>
- SortedList< T>
- Queue< T>
- IEnumerable< T>
- IList< T>
- Collection< T>
- LinkedList< T>

#### Non-Generics
*are not really used much anymore*

- ArrayList
- Hastable
- SortedList
- Queue
- Stack
- IEnumerable
- ICollection
- 

## Readings
- [Collections](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections)
- [Enums](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/enum)
- C# 6.0 in a nutshell - Chapter 7 (Collections)

## Coding Challenge
Find the middle of the Linked Lists

- Using your "data-structures" repository created in class  2
  - add a folder and label it `Linked Lists`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Submit a link to your repo PR in canvas
# ![cf](http://i.imgur.com/7v5ASc8.png) Class 02 

## Learning Objectives
* The student will implement try-catch statements as a form of exception handling within their code.
* The student will setup a debugger within Visual Studio 2017
* The student will understand and be comfortable with debugging through code to identify potential bugs and errors. 

## Lecture Outline
1. **Exception Handling**
    1. `Try {}`
       1. Code that is supposed to be executed should be placed here
    1. `Catch{}`
       1. If an error occurs in the `try{}` block, the CLR looks for the `catch{}` block to handle the exception
       1. Even though you are allowed to not provide a `catch{}` block, it is not industry standard when creating a try/catch statement
    1. `Finally{}`
       1. A `finally{}` block executes regardless if the `catch{}` was hit or not.
    1. `throw`
       1. You can explicitly throw an exception using the `throw` statement.
       1. Can be used to throw a custom error depedent on the type of exception being thrown
1. **Debugging**
    1. What does a Debugger do?
    1. How do you set it up?
       1. Step Into
       1. Step through
       1. Step over

## Readings
1. [How to use Try/Catch block statements](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
1. [Exception Handling Statemetns](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/exception-handling-statements)
1. [How to use Try/Catch block to catch exceptions](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-the-try-catch-block-to-catch-exceptions)
1. [How to use finally blocks](https://docs.microsoft.com/en-us/dotnet/standard/exceptions/how-to-use-finally-blocks)

## Code Challenge 2
Implement a method that takes in a string and reverses it

- Create a new repository called `data-structures` 
  - add a folder and label it `strings`
  - add the code on a branch from this challenge into this repo
  - Describe your approach in the strings folder readme document
  - Spend no more than 90 minutes on this challenge
  - Submit a link to your repo PR in canvas
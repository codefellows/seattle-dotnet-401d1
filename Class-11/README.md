# ![cf](http://i.imgur.com/7v5ASc8.png) Lecture 11

## Intro To Controllers


### Setup
  1. Open up an Empty Core Web application.
  2. Go to NuGet package manager, browse and install Microsoft.AspNetCore.Mvc NuGet package
  3. Modify your code in the Configure() & ConfigureServices() in your Startup.cs
  5. Add a "Controllers" folder to your application
  6. Add a new Controller
  7. Add Actions
  8. Add Routing Template
  9. Save your program and Run. 

### Controller Defaults
1. When creating an empty web app in Core, you will automatically get a home page that says "Hello World"
    - This will run everytime it a controller isnt found. 
    - if you dont want this, just remove it.
    - This is through this section of code in the Startup Class:
    ```csharp
    app.Run(async (context) =>
    {
        await context.Response.WriteASync("Hello World!");
    });
    ```

2. If you want to set a default location modify your app.UseMvc():
    ```csharp
      app.UseMvc(route =>
            {
                route.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");

            });

     ```

### Routing
1. What if we want special Routing? 
1. Create a new Controller
1. add a new Action
1. Add Custom Routing Attributes


### Take it one step further...

1. We want a Controller to have what all/other controllers have:
   - Let's have these controllers inherit from the Controller class
   - Add ` : Controller` to the controller classes already created
     - When starting out with an empty application, you will need to manually add this. 


### Manipulate Data

1. Let's manipulate data from the browser in the controller.

2. Actions in Controllers can take paramters


#### How does it know what to bind to?

- the MVC Model binding system automatically maps the named parameters from the query string in the address bar to parameters in your method. 

#### How Model Binding Works:
1. When MVC receives an HTTP request, it routes it to a specific action method of a controller.
2. It determines which action method to run based on what is in the route data, then binds it to the HTTP request to that action method's parameters.

3. Let's go back to the Route Template:
   - `{controller=Home}/{action=Index}/{id?}`

4. movies/edit/2 --> 
  - rotues to the Movies Controller
  - Edit is the Action
  - accepts an ID (of 2 in this case. )
  - It defaults to whatever is after the '/' to id, unless otherwise specified

**This is all you need to know about it for now, We will cover the other details of Model Binding later on**

## Readings
- [Controllers](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/actions)
- [Routing to Controller Actions](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing)
- [Adding a Controller](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller)
- [Model Binding](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding)

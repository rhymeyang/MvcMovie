[CYB206 Web Application Security - Lab1]

17:50 UTC
Add a Controler(HelloWorldController.cs), according to [Part 2, add a controller to an ASP.NET Core MVC app](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-7.0&tabs=visual-studio).

Change function return type to string, and run the project, it will show plain text of the **HelloWorld** page.



18:10 UTC

Add a View(Index.cshtml) under HelloWorld Folder, according to [Part 3, add a view to an ASP.NET Core MVC app](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-7.0&tabs=visual-studio).

Change the return type of function **Index** back to **IActionResult**, then run the project again,  **HelloWorld** page will show as the view(Index.cshtml) sets.

18:40 UTC

Add an image to Index page, `<img style="display:block; margin:auto; " src="~/img/flower.png"/>` , the image path should use a relative path.

18:59 UTC

Add parameter to page `Helloworld/welcome`, so for url `https://localhost:7291/Helloworld/welcome?name=yang&numTimes=3` it will show the name and number.

Change Welcome page, to show the page as view sets.


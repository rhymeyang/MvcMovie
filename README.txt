[CYB206 Web Application Security - Lab1]

Name: Yun Yang ID: 0853062

# Week 2

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

# Week 3

###  Add Entity Framework MVC Controler

17:35 UTC 
Add Entity Framework MVC Controler, version v1.0.0.0

`ID: mvcControlerWithContextScaffolder`

### Migration

18:17 UTC

Initial Migration, and database created
20240523175346_InitialCreate

```shell
Add-Migration InitialCreate
Update-Database
```




### 18:24 UTC

Finish part 4

### 20:18 UTC

`public async Task<IActionResult> Index(string searchString)` even though the parameter type are the same **string**, if the name changed to `id`,  it will support `https://localhost:7291/Movies/index/rio`, if it is `searchString`, it can only use the format `https://localhost:7291/Movies?searchstring=rio`, for filter.

## Week 4

### Add Rating

From the **Tools** menu, select **NuGet Package Manager** > **Package Manager Console** .

```shell
Add-Migration AddRating
Update-Database
```

list version, **Ensure the Correct Version of .NET SDK**:

```shell
dotnet --list-sdks

```


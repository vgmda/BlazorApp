## BlazorApp
> Blazor is a Single Page Application development framework. The name Blazor is a combination/mutation of the words Browser and Razor (the .NET HTML view generating engine). The implication being that instead of having to execute Razor views on the server in order to present HTML to the browser, Blazor is capable of executing these views on the client.



<p align="center">
  <img width="500" height="400" src="https://user-images.githubusercontent.com/104713435/184557400-da24f7b0-1bdb-4118-b98c-5fd04571a85d.png">
<p align="center"><i>Blazor app with client-side execution
</i></p>
</p>


## Blazor WebAssemby and Blazor Server
 
In the *server-side hosting model (Blazor Server-Side)*, Blazor is executed on the server from within an ASP.NET Core app. UI updates, event handling, and JavaScript calls are handled over a SignalR connection.
 
In the *client-side model (Blazor WebAssembly)*, the Blazor app, its dependencies, and the .NET runtime are downloaded to the browser, and the app is executed directly on the browser UI thread. All UI updates and event handling happen within the same process.

<p align="center">
  <img width="670" height="400" src="https://codewithmukesh.com/wp-content/uploads/2020/05/1blazor-1-1571602480344-1024x547.png?ezimgfmt=ng:webp/ngcb53">
<p align="center"><i>Blazor Server vs Blazor WebAssembly
</i></p>
</p>

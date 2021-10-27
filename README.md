# sbmblazor21

# links

https://github.com/nuboid/sbmblazor21

https://excalidraw.com/sbmblazor

https://codeshare.io/sbmblazor

https://aka.ms/blazor-ebook

https://www.syncfusion.com/succinctly-free-ebooks/confirmation/blazor-webassembly-succinctly

https://github.com/AdrienTorris/awesome-blazor

https://caniuse.com/
https://ysflghou.github.io/BlazorTicTacToe/

# Topics

- javascript integration (leafletdemo)
- browser storage
- authenticatie
- app als desktopapp
- API's
- Azure Cloud SQL DB

# Training Samples

https://github.com/DevExpress/blazor-training-samples

https://github.com/thomasclaudiushuber/Blazor-Training

https://blazor-university.com/

# Links les 2

https://github.com/radzenhq/radzen-blazor

https://www.layoutit.com/build

https://getbootstrap.com/docs/5.1/examples/

https://blazor.radzen.com/

https://github.com/Blazored/LocalStorage

Topics Les 3

https://hovermind.com/blazor/offline-storage.html

- MVVM

- DataRepositories

https://blog.stevensanderson.com/2019/08/03/blazor-indexeddb/
https://github.com/wtulloch/Blazor.IndexedDB

- Component Parameters

- RenderFragments

- dotnet watch run

- LiveSharp

- https://github.com/hassanhabib/PrettyBlazor

- Deploy To Azure

- ServiceCollection

- singleton ChatDemo

https://docs.microsoft.com/en-us/mobile-blazor-bindings/walkthroughs/skiasharp

- https://docs.microsoft.com/en-us/aspnet/core/blazor/progressive-web-app?view=aspnetcore-5.0&tabs=visual-studio
https://github.com/SteveSandersonMS/CarChecker

https://www.telerik.com/blogs/blazor-on-desktop
https://github.com/jspuij/TwokaB/tree/master/sample/BlazorApp.Android


hosten op azure storage


More topics

- Security / Authenticatie
- API's


# Links les 4

https://docs.microsoft.com/en-us/azure/active-directory/develop/quickstart-register-app

https://github.com/Azure-Samples/ms-identity-blazor-wasm

https://github.com/Azure-Samples/ms-identity-blazor-server

https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/standalone-with-authentication-library?view=aspnetcore-5.0

https://docs.microsoft.com/en-us/ef/core/


dotnet command for Entity Framework

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update


 <PackageReference Include="Microsoft.EntityFrameworkCore" Version="5.0.11" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="5.0.11">

    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.11" />

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-XXXXXXX\SQLEXPRESS19;Database=EFDemo;Trusted_Connection=True");
            optionsBuilder.LogTo(Console.WriteLine);
        }

API's
     
https://docs.microsoft.com/en-us/aspnet/core/blazor/call-web-api?view=aspnetcore-5.0&pivots=webassembly





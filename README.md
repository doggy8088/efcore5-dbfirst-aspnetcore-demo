# efcore5-dbfirst-aspnetcore-demo

```sh

dotnet new globaljson --sdk-version 5.0.401
dotnet tool update --global dotnet-ef

mkdir efcore5-dbfirst-aspnetcore-demo
cd efcore5-dbfirst-aspnetcore-demo
dotnet new webapi
code .

git ignore visualstudio > .gitignore
git init
git add .
git commit -m "Initial commit"

dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools

dotnet ef dbcontext scaffold "Server=(localdb)\Projects;Database=ContosoUniversity;Trusted_Connection=True;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -o Models -f

```

# My Coding Zone Session 2023

## Subject: Error handling

I want to create a presentation which shows why error handling is important in C#. I also want to show the difference between static and dynamic languages. And include Railway-Oriented Programming (ROP) in the presentation.

Exceptions are "real" problems. Errors are "expected" problems. Errors are not exceptional. Exceptions are exceptional.

Therefore... Exceptions should be exceptional.

Create a dotnet solution with a lib and a test project. The lib project should have a class with a method that takes a string and returns a string. The method should throw an exception if the input string is null or empty. The test project should have a test that verifies that the method throws an exception if the input string is null or empty.

```sh
dotnet new sln -n ErrorHandling
dotnet new classlib -n ErrorHandling.Lib
dotnet new xunit -n ErrorHandling.Test
dotnet sln add ErrorHandling.Lib/ErrorHandling.Lib.csproj
dotnet sln add ErrorHandling.Test/ErrorHandling.Test.csproj
dotnet add ErrorHandling.Test/ErrorHandling.Test.csproj reference ErrorHandling.Lib/ErrorHandling.Lib.csproj
```

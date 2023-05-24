#!/bin/sh
PROJECTNAME="MyProject"

# C#
dotnet new sln -n "${PROJECTNAME}"

dotnet new classlib -n "${PROJECTNAME}".Lib
dotnet new xunit -n "${PROJECTNAME}".Test

dotnet sln add "${PROJECTNAME}".Lib/"${PROJECTNAME}".Lib.csproj
dotnet sln add "${PROJECTNAME}".Test/"${PROJECTNAME}".Test.csproj

dotnet add "${PROJECTNAME}".Test/"${PROJECTNAME}".Test.csproj reference "${PROJECTNAME}".Lib/"${PROJECTNAME}".Lib.csproj
dotnet add "${PROJECTNAME}".Test/"${PROJECTNAME}".Test.csproj package FluentAssertions
dotnet add "${PROJECTNAME}".Lib/"${PROJECTNAME}".Lib.csproj package CSharpFunctionalExtensions
dotnet add "${PROJECTNAME}".Lib/"${PROJECTNAME}".Lib.csproj package LaYumba.Functional


# F#
dotnet new classlib -lang F# -n "${PROJECTNAME}"FSharp.Lib
dotnet new xunit -lang F# -n "${PROJECTNAME}"FSharp.Test

dotnet add "${PROJECTNAME}"FSharp.Test/"${PROJECTNAME}"FSharp.Test.fsproj reference "${PROJECTNAME}"FSharp.Lib/"${PROJECTNAME}"FSharp.Lib.fsproj
dotnet add "${PROJECTNAME}"FSharp.Test/"${PROJECTNAME}"FSharp.Test.fsproj package Unquote

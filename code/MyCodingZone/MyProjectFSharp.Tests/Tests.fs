module Tests

open MyProjectFSharp.Lib
open Xunit
open Swensen.Unquote

[<Fact>]
let ``My test`` () = true =! true

[<Fact>]
let ``My test 2`` () = Say.hello =! "Hello World!"

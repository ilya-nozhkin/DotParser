﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("DotParser")>]
[<assembly: AssemblyProductAttribute("DotParser")>]
[<assembly: AssemblyDescriptionAttribute("Graphviz dot parser")>]
[<assembly: AssemblyVersionAttribute("1.0.6")>]
[<assembly: AssemblyFileVersionAttribute("1.0.6")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0.6"
    let [<Literal>] InformationalVersion = "1.0.6"

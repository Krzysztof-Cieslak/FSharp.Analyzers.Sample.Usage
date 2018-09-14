// Learn more about F# at http://fsharp.org

open System

let x = None

[<EntryPoint>]
let main argv =
    x.Value
    printfn "Hello World from F#!"
    0 // return an integer exit code
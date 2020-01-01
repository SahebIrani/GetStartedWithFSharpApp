// Learn more about F# at http://fsharp.org

open System

// Define a new function to print a name.
// It is defined above the main function.
let printGreeting name =
    printfn "Hello %s from F#!" name


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code

// Learn more about F# at http://fsharp.org

open System


// Define a new function to print a name.
// It is defined above the main function.
let printGreeting name =
    printfn "Hello %s from F#!" name

[<EntryPoint>]

let main argv =
    // Call your new function!
    printfn "Hello World from F#!"
    printGreeting "Ana"

    //variable in f#
    let a = 20 // define variable
    a= 30 //Error

    //let aa mutable = 20
    //aa <- 30 //a is now 30


    let sum a b = a+b
    printfn "%i" (sum 2 3)








    Console.ReadKey() |> ignore

    0 // return an integer exit code

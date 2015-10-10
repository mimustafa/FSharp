// Assignment 2
open System

let teenage (argv : string []) =
    let mutable continueLooping = true
    if (argv.Length ) < 2 then continueLooping <- false
       
    let mutable counter = 0
    while continueLooping do
        let name = argv.[counter]      
        let canparse, age = Int32.TryParse(argv.[counter + 1])
        if canparse && age <13 then 
           Console.WriteLine(name + " is a kid")
        elif (canparse && (age >= 13 && age < 20)) then
           Console.WriteLine(name + " is a teenager")
        elif (canparse && (age >= 20)) then
           Console.WriteLine(name + " is no longer a teenager")
        else 
           Console.WriteLine("Wrong age! Please enter name and age pair as abcd 12 fgh 16 pqr 23")
       
       
        counter <- counter + 2
        if (argv.Length - counter) <= 0 then continueLooping <- false
    0
// Set the Command Line Arguments before running e.g. 
// jonas 12 jhon 16 peter 20 mattias 30

[<EntryPoint>]
let main argv =
  //let test = Console.ReadLine().ToString() 
  let test = teenage argv
  Console.ReadKey()
  0 // return an integer exit code

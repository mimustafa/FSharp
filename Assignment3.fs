open System

let goldenRatio = (1.0 + Math.Sqrt(5.0)) / 2.0

// print get a tuple and print in tuple format
let print tuple =
   match tuple with
    | (a, b) -> printfn "(%A, %A)" a b


[<EntryPoint>]
let main argv = 
    // get a list of numbers frm user
    let numberlist =
        [ let run = ref true
          while !run do
              Console.Write("Enter the number: ")
              let number = Console.ReadLine()
              yield (int number)
              Console.Write("Do you want to add more numbers (y/n)? ")
              if Console.ReadLine().ToLower() = "y" then
                   run := true
              else run := false ]
    // create a sequeance where each member is a tuple (number, number * GoldenRatio)             
    let tupleseq =
        seq {
            for x in numberlist do
                 yield (x, goldenRatio * (float x))
        }
    // print each tuple in tupleseq 
    for x in tupleseq do
        print x
    
    Console.ReadKey()
    0 // return an integer exit code

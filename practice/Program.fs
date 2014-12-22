// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

//let oneToNine () = [1..9]
let rec printSet (s) = 
    match s with 
        | [] -> printfn "empty"
        | h :: t -> printfn "%d" h // print the head element of a set then print all the rest after it
                    printSet t

let zeta k e = 
    let inner(i) = 1.0/(double(i)**k) 
    let rec seqInfinite i xp = 
        let x = xp + inner(i)
        match abs(xp - x) with
            | dx when dx <= e -> x
               //seqInfinite (i+1) x
            | _ -> seqInfinite(i+1) x
    seqInfinite 1 0.0

let multiples =
    seq { for i in 1..9 do
            for j in 1..9 do
                yield (i, j, i*j)}



    //printfn "%A" seqInfinite

(*
        | [i] -> printfn "one"
                 printfn "%d" i
                 printSet []
        | [i;j;] -> //printfn "%d" i
                    //printfn "%d" j
                    printfn "two"
                    printSet [i;]
                    printSet [j;]
                    //printSet [i;j;] this amkes infinite loop

        | [i;j;k;] -> printfn "three"
                      printSet [i;] 
                      printSet [j;k;]
        | [i;j;k;l;] -> printfn "four"
                        printSet [i;]
                        printSet [j;k;l;]
*)



[<EntryPoint>]
let main argv = 
    printfn "Hello, J"
//    printfn "%A" argv
    //printSet [3;5;6;10;15;]
    let oneToNine() = [1..9] 

    printSet [for i in oneToNine() -> i* 3]
    printSet [for j in oneToNine() -> j * 5]

    //zeta 0.0 1.0
    printfn "%f" (zeta 15.0 0.0000001)
    0
    //multiples.GetHashCode
(*
    Seq.iter ((fun e -> 
                    match e with 
                        | (i, j, k) -> 
                            printfn "%d %d %d" i j k) 
              (multiples))
*)
    
 // return an integer exit code


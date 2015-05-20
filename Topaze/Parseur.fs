module Parseur

open FParsec

let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let isString c = isLetter c || isDigit c || c = ' '

let affichage = pstringCI "afficher \"" >>. many1Satisfy isString .>> pstring "\""

let testage = test affichage "AFFICHER \"Bonjour Mondé\""



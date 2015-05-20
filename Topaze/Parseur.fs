module Parseur

open FParsec

let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let ws = skipManySatisfy (fun c -> c = ' ' || c = '\t' || c='\r')

let estChaine c = isLetter c || isDigit c || c = ' '

let pChaineEntreGuillemets = pstring "\"" >>. many1Satisfy estChaine .>> pstring "\""

let pCommande s = pstringCI s .>> ws

let affichage = pCommande "afficher" >>. pChaineEntreGuillemets 

let testage = test affichage "AFFICHER \"Bonjour Mondé\""



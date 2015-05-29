module Parseur

open FParsec

let test p str =
    match run p str with
    | Success(result, _, _)   -> printfn "Success: %A" result
    | Failure(errorMsg, _, _) -> printfn "Failure: %s" errorMsg

let ws = skipManySatisfy (fun c -> c = ' ' || c = '\t' || c='\r')

let estChaine c = isLetter c || isDigit c || c = ' '
let estNomVariable c = isLetter c || isDigit c

let pChaineEntreGuillemets = pstring "\"" >>. many1Satisfy estChaine .>> pstring "\""

let pCommande s = pstringCI s .>> ws

let pNomVariable = many1Satisfy estNomVariable .>> ws

let pNomVaut = pNomVariable .>> pstringCI "vaut" .>> ws

let pAffichage = pCommande "afficher" >>. pChaineEntreGuillemets |>> (fun chaine -> Affichage(chaine))

let pInitialisation = pNomVaut .>>. pChaineEntreGuillemets |>> (fun (nom, valeur) -> Initialisation_Chaine(nom, valeur))

let pInstructions = pAffichage <|> pInitialisation

let parse (program:string) =    
    match run pInstructions program with
    | Success(result, _, _)   -> result 
    | Failure(errorMsg, e, s) -> failwith errorMsg

module Interpreteur

let mutable variables = Map.empty

let créer nom valeur = 
    variables <- variables.Add(nom, valeur)

let evaluerExpression = 
    let rec evalInterieur expression = 
        match expression with
        | Initialisation_Chaine (nom, valeur) -> créer nom valeur
        | Affichage (message) -> printfn "%s" message
    evalInterieur

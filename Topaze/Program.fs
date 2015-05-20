let mutable variables = Map.empty

let créer nom valeur = 
    variables <- variables.Add(nom, valeur)
    printfn "variable %s est maintenant %s" nom valeur

let evaluerExpression = 
    let rec evalInterieur expression = 
        match expression with
        | Initialisation_Chaine (nom, valeur) -> créer nom valeur
        | Affichage (message) -> printfn "%s" message
    evalInterieur

let nouvelleInstruction = Initialisation_Chaine("x", "bonjour")

evaluerExpression nouvelleInstruction

[<EntryPoint>]
let main argv = 
    Parseur.testage
    0

[<EntryPoint>]
let main argv = 
    let resultatParsing = Parseur.parse "AFFICHER \"Bonjour Mondé\""
    Interpreteur.evaluerExpression resultatParsing
    0

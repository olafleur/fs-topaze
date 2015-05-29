[<EntryPoint>]
let main argv = 
    let resultatParsing = Parseur.parse "AFFICHER \"Bonjour Mondé\""
    Interpreteur.evaluerExpression resultatParsing
    let resultatParsing = Parseur.parse "Nom vAuT \"Olivier Lafleur\""
    Interpreteur.evaluerExpression resultatParsing
    Interpreteur.variables |> Map.iter (fun key value -> printfn "[%s;%s]" key value)
    0

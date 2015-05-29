let nouvelleInstruction = Initialisation_Chaine("x", "bonjour")

[<EntryPoint>]
let main argv = 
    Interpreteur.evaluerExpression nouvelleInstruction
    Parseur.testage
    0

let nouvelleInstruction = Initialisation_Chaine("x", "bonjour")
let autreInstruction = Affichage("salut")

[<EntryPoint>]
let main argv = 
    Interpreteur.evaluerExpression nouvelleInstruction
    Interpreteur.evaluerExpression autreInstruction
    Parseur.testage
    Interpreteur.evaluerExpression (Parseur.parse "AFFICHER \"Bonjour Mondé\"")
    0

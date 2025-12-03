let age = Number(prompt("Veuillez saisir votre age : "));

// Pour donner une condition en javascript, nous utilisons le mot-clé 'if'
if (age >= 18){
  alert("Vous êtes majeur"); // Si la condition est vrai alors j'execute cette instruction.
}


// Il est possible d'ajouter un sinon via le mot-clé "else"
// Attention pour ajouter un bloc sinon, le "if" est obligatoire.
if (age <= 25){
  alert("Vous êtes éligible à la carte jeune.") // Si age >= à 25 ans
} 
else {
  alert("Désolé, vous n'êtes pas éligible") // Si age < 25
}


// Pour ajouter plusieurs conditions, nous pouvons ajouter des bloc "else if"
// Nous pouvons ajouter autant de "else if" que le souhaite mais le "if" et le "else" est obligatoire.
if (age < 15 && age >= 0){
  alert ("Vous êtes un enfant") 
}
else if (age > 15 && age < 18) {
  alert("Vous êtes ado"); 
}
else if (age >= 18 && age <= 25) {
  alert("Vous êtes jeune adulte")
}
else if (age > 25 && age <= 65){
  alert("Vous êtes adulte")
}
else {
  alert("Vous êtes une personne agée")
}




// Demander nb photocopie
// Stocker nb photocopie
let nbPhotocopie = Number(prompt("Veuillez entrer un nombre de photocopie : "));

// Créer un resultat
let resultat; 

// Si nb photocopie est inférieur à 10
if (nbPhotocopie < 10){
  // Alors resulat = nb photocopie x 0.5 
  resultat = nbPhotocopie * 0.5 ;
} 
// Si nb photocopie est entre 10 et 20 (inclus)
else if (nbPhotocopie <= 20){
  // Alors resultat = nb photocopie x 0.4 
  resultat = nbPhotocopie * 0.4; 
}
// Sinon resultat = nb photocopie x 0.3 
else {
  resultat = nbPhotocopie * 0.3; 
}

// Afficher le résultat
alert("Prix total : " + resultat + "€");



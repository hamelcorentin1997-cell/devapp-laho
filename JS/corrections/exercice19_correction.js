// Déclarer les variables
let nb1, nb2;
let resultat; 

// Déclaration de la fonction
function retourneLePlusGrand(nombreA, nombreB){
  
  if (nombreA > nombreB){
    return nombreA;
  }

  return nombreB;
  
}

// Demander 2 nombres à l'utilisateur
nb1 = Number(prompt("Veuillez entrer nombre 1 : "));
nb2 = Number(prompt("Veuillez entrer nombre 2 : "));

// Appeler la fonction
resultat = retourneLePlusGrand(nb1, nb2)

alert("Le nombre le plus grand est : " + resultat);
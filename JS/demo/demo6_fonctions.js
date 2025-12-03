// Déclaration de la fonction
// function nomDeLaFonction (parametres){ }
function auCarre(nombre, puissance){
  return Math.pow(nombre, puissance); // Une fonction peut retourner une valeur avec le mot-clé return;
}

// "Procédure" car cette fonction ne retourne rien.
function afficherQqch(){
  alert("J'affiche qqch !")
}

// Pour utiliser une fonction, nous devons l'appeler avec son nom.
let resultat = auCarre(5, 2); // (Les informations transmit à une fonction s'appellent des arguments.)

afficherQqch(); // Pour appeler une Procédure, c'est exactement le même principe.

alert(resultat)


// Attention l'ordre des arguments à son importance
// auCarre(5, 2) != auCarre(2, 5)

// Nous pouvons donner des valeur par défaut à nos parametres en leur affectant directement une valeur.
// Attention, les parametres par défauts doivent être mis le plus à droite possible (après les parametres obligatoire)
function sePresenter(age, nom = "Titi", prenom = "Toto"){
  alert("Bonjour je m'appelle " + nom + " " + prenom + " et j'ai " + age + " ans.");
}

// Je donne tout les parametres et j'écrase les valeurs par défauts
sePresenter(30, "Walle", "Loick");
// Je ne donne que le parametres obligatoire (nom et prenom deviennent par défauts)
sePresenter(30);
// Je donne le premier paramete obligatoire, j'écrase le deuxieme paramete qui est par défauts 
// et je laisse le dernier parametre avec sa valeur par défaut.
sePresenter(30, "Marco");
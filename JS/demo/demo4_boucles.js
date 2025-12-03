let nombre = 0; 

// On utilise la boucle while (tant que) quand on ne sait pas précisemment le nombre fois que nous allons itérer.

while(nombre < 3){
  console.log(nombre);
  nombre = nombre + 1; // Cette ligne va permettre d'éviter la boucle infinie.
}

console.log("Fin de ma boucle. ")

let i = 0

// La boucle peut recevoir la condition true si l'on souhaite avoir une boucle infinie.
while(true){
  
  i = i + 1;
  
  if(i == 5){
    continue; // Permet de passer à l'itération suivante sans lire le reste des instructions.
  }
  
  if(i == 7){
    break; // Permet de "casser" la boucle si lire la suite des instructions (stop de façon forcer)
  }
  
  console.log(i);
}

console.log("Fin de ma boucle. ")


// Ici, nous avons une boucle tant que qui va boucler tant que nous n'avons pas la valeur finale.
let b = 0; // La valeur initial est de 0

console.log("Boucle while (compteur)")
while(b < 10){ // La valeur final est de 10
  b++; // Le pas est de 1
  console.log(b)
}

// Ici, nous bouclons jusqu'a une valeur finale également.
console.log("Boucle for (compteur)")
for(let i = 1; i <= 20; i++){ // valeur initial + valeur final + pas = 1
  console.log(i);
}


// La boucle faire tant..que est comme une boucle tant..que à l'exception quelle est parcourue AU MOINS 1 fois.
// Elle est utile quand la condition dépend d'une information reçu par l'utilisateur ou doit être calculé.
console.log("Boucle do..while (instructions effectué au moins 1 fois.")

let nom = "Walle";

do{
  nom = prompt("Veuillez entrer le bon nom : ")
}while(nom != "Walle");

alert("Bienvenue Mr Walle ! ")

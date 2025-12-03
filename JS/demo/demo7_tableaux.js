// Déclarer un tableau vide.
let joursSemaine = []; 

// Ajout d'un élément en fin de tableau
joursSemaine.push("lundi"); 

// Ajout de plusieurs éléments en une fois
joursSemaine.push("mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche");

// Permet d'afficher proprement un tableau
console.table(joursSemaine);

// Supprimer le dernier élément du tableau
joursSemaine.pop(); 

// Nous pouvons également récupérer se dernier élément en l'affectant à une variable
let jour = joursSemaine.pop(); 

console.table(joursSemaine);
console.log(jour);

// Il est possible d'afficher une valeur du tableau (sans la supprimer) en utilisant l'indice correspondant.
console.log(joursSemaine[2]) // Mercredi

// Trouver le premier index d'un élément donnée (-1 si non trouvé)
let indexMardi = joursSemaine.indexOf("mardi"); 
console.log(indexMardi);

// delete permet de supprimer un élément du tableau avec l'indice donnée
delete joursSemaine[1];

console.table(joursSemaine);


// Découper un tableau (début, fin)
let nouveauTableau = joursSemaine.splice(2, 4)

console.table(nouveauTableau)
console.log(nouveauTableau[0])

console.table(joursSemaine);

// Pour connaitre la taille d'un tableau
console.log(nouveauTableau.length); 

// Ajout d'un élément à un indice précis
joursSemaine[100] = "toto"
joursSemaine[50] = "tata"
joursSemaine[50] = "tutu" // Nous modifions la valeur à l'indice 50 (écrase les données)
console.table(joursSemaine);
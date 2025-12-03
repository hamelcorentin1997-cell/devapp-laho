// Commentaire sur une ligne

/* 
  Un commentaire
  sur
  plusieurs lignes
*/


// let Identificateur = valeur
// Les variables en Javascript suivent la norme camelCase

// Une chaine de caractere (String)
let prenom = "Loick"

// var est l'ancien mot-clé permettant de déclarer une variable.
var nom = "Toto"

// Un nombre (Number)
let age = 25 
let taille = 180.0

// Booléen (Vrai ou Faux)
let estAdulte = true
let estPresident = false

// Attention, Javascript est case sensitive
let AGE = 40

// Pour afficer un élément dans la console
console.log("prenom : " + prenom + " - age: " + age + " - est un adulte : " + estAdulte)


// Je modifie la variable age
age = 30
console.log("Age vaut : " + age)
age = 31
console.log("Age vaut : " + age)


// Nous pouvons déclarer une constante avec le mot-clé "const"
// Une constante va stocker une valeur et ne pourra plus en changer 
// durant toute l'execution du programme.
const EMAIL = "loick@utopios.solutions"
console.log("Email : " + EMAIL)

// Ici, nous recevons une erreur car nous essayons malgrès tout de modifier une constante
// EMAIL = "toto"
// console.log("Email : " + EMAIL)

// Une constante à pour norme le SCREAMING_SNAKE_CASE
// Dans un fichier Javascript, nous pouvons stocker des couleurs en css
const COULEUR_JAUNE = "#ffff14" 

// Il est possible de voir le type de nos variables/constantes avec typeof()
console.log("estAdulte " + typeof(estAdulte))
console.log("age " + typeof(age))
console.log("Email " + typeof(EMAIL))

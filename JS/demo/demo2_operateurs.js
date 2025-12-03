let a,b; // Déclacration de 2 variables. 

// Opérateurs arithmétiques
// Prompt permet de récupérer la saisie de l'utilisateur
a = prompt("Veuillez saisir a :"); 
b = prompt("Veuillez saisir b : ");

// La saisie récupérer est toujours une chaine de caractere
// Pour de futur calcul, il est nécessaire de les convertir en nombre.
a = Number(a)
b = Number(b)

// Alert permet d'afficher un résultat, non pas dans la console
// mais dans une pop-up (notification)
alert("Addition de a et b : " + (a + b)); // Addition
alert("Soustraction de a et b : " + (a - b)); // Soustraction
alert("Multiplication de a et b : " + (a * b)); // Multiplication
alert("Division de a et b : " + (a / b)); // Division 
alert("Module de a et b : " + (a % b)); // Modulo (reste d'une division)
alert("Puissance de a et b : " + (a ** b)); // Exponentiel

// Opérateurs relationnels 
let age = Number(prompt("Veuillez saisir votre age : "))
let estMajeur = age >= 18; // Supérieur ou égal
let estMineur = age < 18; // Strictement inférieur
let vingtAns = age == 20; // égal  
let pasTrenteAns = age != 30; // différent 

alert("est majeur : " + estMajeur)
alert("est mineur : " + estMineur)
alert("vous avez vingt ans : " + vingtAns)
alert("vous n'avez trente ans : " + pasTrenteAns)

alert("20 == '20' : " + (20 == "20")); // égal
alert("20 != 19 : " + (20 != 19)); // différent
alert("20 === '20' : " + (20 === "20")); // strictement égal
alert("20 !== '20' : " + (20 !== "20")); // strictement différent

// Opérateur logique
// ET : &&
// OU : || 
// Non : ! 

alert("Vrai ET Vrai : " + (true && true)); // true
alert("Vrai ET Faux : " + (true && false)); // false

alert("Vrai OU Vrai : " + (true || true)); // true
alert("Faux OU Faux : " + (false || false)); // false
alert("Faux OU Vrai : " + (false || true)); // true

alert("L'inverse de Vrai est : " + !true); // false
alert("L'inverse de Vrai ET Faux : " + !(true && false)); // true 

alert(true && ((false || !true) || (true || true))); // true
// Exercice 2 
let a;
let b;

a = 1; // a -> 1
b = 2; // b -> 2 

a = b; // a -> 1 -> 2 
b = a; // b -> 2 -> 2 

console.log("La valeur de a est : " + a);
console.log("La valeur de b est : " + b);

// Non, cet algorithme ne permet d'échanger les valeurs car la valeur a est écraser
// par la valeur présente dans b (1 disparait)
let a;

a = Number(prompt("Veuillez entrer un nombre entier : "));

let estDivisiblePar3 = a % 3 == 0; 

alert(estDivisiblePar3) // Soit true soit false

if (estDivisiblePar3){
  alert(a + " est divisible par 3.")
} 
else {
  alert(a + " n'est pas divisible par 3.")
}
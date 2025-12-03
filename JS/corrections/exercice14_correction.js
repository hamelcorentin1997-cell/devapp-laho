
let n = Number(prompt("Veuillez donner un entier : ")); 

let somme = 0;

for(let i = 1; i <= n; i++){
  somme += i;
}

alert("La somme des entier de 1 à " + n + " est égale à " + somme); 

// boucle for
let maximum; 

for(let i = 0; i < 6; i++){
  nombre = Number(prompt("Veuillez entrer un nombre : "));
  
  if(i == 0){ //
    maximum = nombre;
  }else{
    // Dans le cas ou, nous sommes sur les autres itération (pas la premiere)
    if ( maximum < nombre){
      maximum = nombre; 
    }
  }
}

alert("Le nombre maximum est : " + maximum);
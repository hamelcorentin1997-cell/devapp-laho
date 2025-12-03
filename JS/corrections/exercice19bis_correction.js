
function donnerHeure(heure = "12", minute = "00"){
  return heure + "h" + minute; 
}

let h = prompt("Veuillez donner une heure : ");
let m = prompt("Veuillez donner une heure : ");

alert(donnerHeure(h, m));
alert(donnerHeure());

function estPair(nombre){
  
  if(nombre % 2 == 0){
    return true;
  }
  
  return false;
  
  // ternaire : 
  // return nombre % 2 == 0 ? "Le nombre est pair " : "Le nombre est impair";
}

if(estPair(5)){
  alert("Votre nombre est pair !")
} else {
  alert("Votre nombre est impair !")
}

let taille = Number.parseInt(prompt("Veuillez saisir une taille : ")); 
let poids = Number.parseInt(prompt("Veuillez saisir un poids : ")); 

// Méthode 1
if(poids < 43 || poids > 77){
  alert("Taille indisponible !")
}
else if(taille < 145 || taille > 183){
  alert("Taille indisponible !")
}
else if(poids < 47){
  if(taille < 169){
    alert("Taille 1")
  }
  else{
    alert("Taille indisponible")
  }
}
else if(poids < 53){
  if(taille < 166){
    alert("Taille 1")
  }
  else if (taille < 178){
    alert("Taille 2")
  }
  else{
    alert("Taille indisponible")
  }
}
else if(poids < 59){
  if(taille < 163){
    alert("Taille 1")
  }
  else if (taille < 175){
    alert("Taille 2")
  }
  else {
    alert("Taille 3")
  }
}
else if(poids < 65){
  if(taille < 160){
    alert("Taille 1")
  }
  else if (taille < 172){
    alert("Taille 2")
  }
  else {
    alert("Taille 3")
  }
}
else if(poids < 71){
  if(taille < 157){
    alert("Taille indisponible")
  }
  else if (taille < 169){
    alert("Taille 2")
  }
  else {
    alert("Taille 3")
  }
}
else{
  if(taille < 160){
    alert("Taille indisponible")
  }
  else {
    alert("Taille 3")
  }
}


// Méthode 2 
if(taille < 145 || taille > 183 || poids < 43 || poids > 77){
  alert("Taille indisponible !")
}
else if((taille <= 160 && poids <= 65) || (taille <= 163 && poids <= 59) || (taille <= 166 && poids <= 53) || (taille <= 169 && poids <= 47)){
  alert("Taille 1");
}
else if((taille <= 169 && (poids <= 66 && poids <= 71)) || (taille <= 172 && (poids <= 65 && poids >= 60)) || (taille <= 175 && (poids <= 59 && poids >= 54)) || (taille <= 178 && (poids <= 53 && poids >= 48))){
  alert("Taille 2");
}
else if((taille >= 163 && poids >= 72) || (taille >= 172 && poids >= 66) || (taille >= 175 && poids >= 60 ) || (taille >= 178 && poids >= 54)){
  alert("Taille 3");
}
else {
  alert("Taille indisponible !");
}
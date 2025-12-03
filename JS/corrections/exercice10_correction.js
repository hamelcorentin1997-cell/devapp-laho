let nombre = Number(prompt("Veuillez entrer un nombre entre 1 et 3 : "));

while(nombre < 1 || nombre > 3){
  alert("Vous n'avez pas rentrer 1, 2 ou 3 !");
  
  nombre = Number(prompt("Erreur, veuillez entrer un nombre entre 1 et 3 : "));
}

alert("Vous avez bien entré un nombre entre 1 et 3.")
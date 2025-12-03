let capital, taux, nbAnnee, resultat, capitalCalcule;

capital = Number(prompt("Veuillez donner un capital de départ : ")); 
taux = Number(prompt("Veuillez donner un taux fixe (%) : "));
taux = taux / 100;
nbAnnee = 0;
capitalCalcule = 0;

while(capitalCalcule < (capital * 2)){

  nbAnnee++;
  capitalCalcule = capital * Math.pow((1 + taux), nbAnnee); 
  capitalCalcule = Math.round(capitalCalcule); 
  
}

alert("Votre capital calculé est de " + capitalCalcule); 
alert("Le nombre d'année nécessaire au doublement de votre capital est de " + nbAnnee); 
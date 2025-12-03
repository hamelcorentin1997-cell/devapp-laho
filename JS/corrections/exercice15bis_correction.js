let habitantInitial = 96809;
let habitantCalculee = habitantInitial; 
let tauxAcc = 0.89 / 100;
let habitantCible = 120000;
let nbAnnee = 0;

while(habitantCalculee < habitantCible){
  habitantCalculee = habitantCalculee + habitantCalculee * tauxAcc
  nbAnnee++;
}

alert("Pour atteindre " + habitantCible + " habitants, il nous faut attendre " + nbAnnee + " ans.");
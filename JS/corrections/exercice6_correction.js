// Déclarer c (capital), t (taux), n (nombre d'année), r (resultat), cp (capital placé)
let capital, taux, nbAnnee, resultat, capitalCalcule;

// Donner à c notre capital de départ (insertion utilisateur)
capital = Number(prompt("Veuillez donner un capital de départ : ")); 

// Donner le taux fixe (ex: 0.04) (insertion utilisateur)
taux = Number(prompt("Veuillez donner un taux fixe (%) : "));
taux = taux / 100; // 4% devient 0.04 

// Donner le nombre d'année (insertion utilisateur)
nbAnnee = Number(prompt("Veuillez donner un nombre d'année : ")); 


// J'effectue le calcul du capital placé
// Pour effectuer une puissance nous utilisant : Math.pow(5, 2) => 5² => 25
// capital placé = capital * Math.pow((1 + taux), nombre d'année)
capitalCalcule = capital * Math.pow((1 + taux), nbAnnee); 

// capital placé = Math.round(capital placé) => Arrondir notre valeur 
capitalCalcule = Math.round(capitalCalcule); 

// J'affiche le capital placé (cp)
alert("Votre capital calculé est de " + capitalCalcule); 

// Je fais la différence entre le capital placé et le capital d'origine
resultat = capitalCalcule - capital; 

// J'affiche le resultat (r)
alert("Vos gains sont de " + resultat); 



// Demander et stocker l'age donné par l'utilisateur
let age = Number(prompt("Veuillez donner l'age de l'enfant : ")); 


if (age < 0){
  alert("Age incorrect !")
}
// Si age < 3
else if (age < 3 ){
  // Alors afficher une erreur (trop jeune)
  alert("Votre enfant est trop jeune !"); 
}
// Sinon si age >= 3 ET age <= 6
else if (age >= 3 && age <= 6){
  // Alors afficher "Baby"
  alert("Votre enfant est dans la catégorie Baby !")
}
// Sinon si age >= 7 ET age <= 8
else if (age >= 7 && age <= 8){
  // Alors afficher "Poussin"
  alert("Votre enfant est dans la catégorie Poussin !")
}
// Sinon si age >= 9 ET age <= 10
else if (age >= 9 && age <= 10){
  // Alors afficher "Pupille"
  alert("Votre enfant est dans la catégorie Pupille !")
}
// Sinon si age >= 11 ET age <= 12
else if (age >= 11 && age <= 12){
  // Alors afficher "Minime"
  alert("Votre enfant est dans la catégorie Minime !")
}
// Sinon si age >= 13 ET age < 18
else if (age >= 13 && age < 18){
  // Alors afficher "Cadet"
  alert("Votre enfant est dans la catégorie Cadet !")
}
// Sinon
else
{
  // Afficher une erreur (trop agé)
  alert("Votre enfant est trop agé !")
}
  

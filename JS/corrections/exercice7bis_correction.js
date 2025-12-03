// // Demander et stocker l'age donné par l'utilisateur
// let age = Number(prompt("Veuillez donner l'age de l'enfant : ")); 

// switch (age) {
//   case 3:
//   case 4:
//   case 5:
//   case 6:
//     alert("Votre enfant est dans la catégorie Baby !")
//     break;
//   case 7:
//   case 8: 
//     alert("Votre enfant est dans la catégorie Poussin !")
//     break
//   case 9:
//   case 10: 
//     alert("Votre enfant est dans la catégorie Pupille !")
//     break
//   case 11:
//   case 12: 
//     alert("Votre enfant est dans la catégorie Minime !")
//     break  
//   case 13:
//   case 14:
//   case 15:
//   case 16:
//   case 17:
//     alert("Votre enfant est dans la catégorie Cadet !")
//     break   
//   default:
//     alert("Votre enfant est hors-catégorie")
//     break; 
// }


// Demander et stocker l'age donné par l'utilisateur
let age = Number(prompt("Veuillez donner l'age de l'enfant : ")); 

switch (true) {
  case (age < 3):
    alert("Votre enfant est trop jeune !")
    break;
  case (age <= 6):
    alert("Votre enfant est dans la catégorie Baby !")
    break;
  case (age <= 8): 
    alert("Votre enfant est dans la catégorie Poussin !")
    break
  case (age <= 10):
    alert("Votre enfant est dans la catégorie Pupille !")
    break
  case (age <= 12):
    alert("Votre enfant est dans la catégorie Minime !")
    break  
  case (age <= 17):
    alert("Votre enfant est dans la catégorie Cadet !")
    break   
  default:
    alert("Votre enfant est hors-catégorie")
    break; 
}



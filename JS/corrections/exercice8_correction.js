let AB, AC, BC;

AB = Number(prompt("Veuillez entrer AB : ")); 
AC = Number(prompt("Veuillez entrer AC : ")); 
BC = Number(prompt("Veuillez entrer BC : ")); 

if (AB == AC){
  if (AC == BC){
    alert("Le triangle est équilatéral."); 
  }
  else{
    alert("Le triangle est isocèle en A."); 
  }
}
else if (AB == BC){
  alert("Le triangle est isocèle en B."); 
}
else if (AC == BC){
  alert("Le triangle est isocèle en C."); 
} 
else {
  alert("Le triange n'est pas isocèle (ni en A, B ou C)")
}
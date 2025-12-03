let notes = [];

let note, numNote;
numNote = 1;

for(let i = 0; i < 15; i++){
  note = Number(prompt("Veuillez saisir la note n°"+ numNote +" : "));
  
  notes.push(note);
  numNote++; 
}

console.table(notes);
// Demo sur incrémentation et décrémentation
let a = 0;

console.log(a); // 0

a++; // => a = a + 1; 
console.log(a); // 1

a--; // => a = a - 1; 
console.log(a); // 0

console.log(a++); // ici, nous affichons 0 car a++ n'est effectué qu'après notre instruction.

console.log(a); // 1

console.log(++a); // ici, nous affichons 2 car ++a sera effectué avant la fin de l'instruction.


a = a + 2; // a = a + 2 = 4
console.log(a)

a += 2; // a = a + 2 => 6
console.log(a)

a -= 2; // 4 
a *= 2; // 8 
a /= 2; // 4 
a %= 2; // 0

console.log(a)
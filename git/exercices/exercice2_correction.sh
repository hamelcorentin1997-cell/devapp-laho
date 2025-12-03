# partie 1
git init

# partie 2
touch fichier1.txt
git add fichier1.txt
git commit -m "Ajout du fichier1"

# partie 3
touch fichier2.txt
git add fichier2.txt
git commit -m "Ajout du fichier2"

# partie 4
touch fichier3.txt
git add fichier3.txt
git commit -m "Ajout du fichier3"

# partie 5
nano fichier3.txt
 > "J'ajoute une ligne"

git add fichier3.txt
git commit -m "Modification de fichier3"

# partie 6
git log --oneline

# partie 7
# git diff commit1 commit2
git diff c3d3c34 1530694
# Il est possible de donner seulement le commit1 pour voir la différence avec le commit actuel.
git diff c3d3c34

# partie 8
# Execute l'action inverse effectué dans le commit spécifié.
git revert 16eefea 

# partie 9
# Réinitialise jusqu'au commit 1 mais garde les modifications en locale. 
git reset c3d3c34 

# partie 10
git add .
git commit -m "Ajout de fichier 3 & modification"

# partie 11
git log --oneline
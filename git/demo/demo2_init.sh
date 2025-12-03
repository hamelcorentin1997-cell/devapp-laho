# Pour initialiser un projet git (créer un dossier .git invisible)
git init 

# Pour afficher l'état actuel de mes fichiers dans le dossier courant.
git status

# Les différent état de fichiers sont :
# - Untracked (rouge): fichier/dossier qui n'ont jamais été commit.
# - staged (couleur verte) : Le fichier a été donné pour être dans le prochain commit
# - unmodified (n'apparait) : L'état des fichier/dossier qui n'ont pas été manipulé.
# - modified (rouge) : Le fichier a été modifié ou supprimé.

# Permet d'ajouter un fichier dans le prochain commit
git add fichier.txt

# Permet d'ajouter tout les fichiers présent dans le dossier courant.
git add .
git add -A
git add --all

# Pour "sauvegarder" l'état actuel de notre projet (ce qui a été ajouter via add), nous devons utiliser commit
git commit -m "Message de commit"

# Dans le cas ou aucun nouveau fichier n'a été créer, on peut ne pas préciser le add
# Pour cela, nous ajoutons l'option -am afin d'ajouter directement les modifications.
git commit -am "Message de commit" 

# Pour afficher l'historique de nos commit
git log

# Pour afficher un nombre précis des derniers commit
git log -p -2

# Pour afficher l'historique sur une ligne
git log --oneline

# Pour afficher l'historique sous forme de graph
git log --oneline --graph --all

# Nous pouvons connaitre la différence entre le commit actuelle et un commit spécifié
git diff <commit_id>

# Il est également possible de voir la différence entre 2 commit spécifique
git diff <commit_id> <commit_id2>
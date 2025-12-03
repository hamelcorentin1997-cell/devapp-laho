# Exercice - tag

# 1. Crée un nouveau repository
git init
# 2. Ajouter un nouveau fichier et le commit (commit 1)
touch fichier1
git add fichier1.txt
git commit -m "Ajout du fichier1"
# 3. Modifier fichier1 et le commit (commit 2)
git add fichier1.txt
git commit -m "Modification de fichier1"
# 4. Crée un tag "temp" sur le commit actuel.
git tag temp
# 5. Afficher l'historique pour voir le tag sur le commit.
git log --oneline
# 6. Modifier fichier1 à nouveau et le commit (commit 3)
git add fichier1.txt
git commit -m "2e Modification de fichier1"
# 7. Crée un tag "v1.0" sur le commit 1 avec une description.
git tag -a v1.0 -m "Version 1.0" 8615501
# 8. Afficher tout les tags
git tag
# 9. Déplacer vous sur le tag "temp" et vérifier que le contenu de fichier1 a bien changé.
git checkout temp
# 10. Revenir sur le dernier commit de la branche.
git checkout main
# 11. Réinitialiser votre projet jusqu'au tag "v1.0" en supprimant le travail local.
git reset --hard v1.0
# 12. Afficher la description du tag "v1.0"  
git show v1.0

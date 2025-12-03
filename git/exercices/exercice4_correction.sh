# 1. Créer un nouveau repository Git
git init
# 2. Ajouter un fichier et le commiter
echo "Ajout d'un fichier" > fichier1.txt
git add fichier1.txt
git commit -m "Ajout de fichier 1"
# 3. Ajouter un deuxième fichier et le commiter
echo "Ajout d'un 2e fichier" > fichier2.txt
git add fichier2.txt
git commit -m "Ajout de fichier 2"
# 4. Vérifier l’historique (on doit avoir 2 commits)
git log --oneline
# 5. Faire des modifications sur le deuxième fichier et le commiter
nano fichier2.txt
git add fichier2.txt
git commit -m "Modification de fichier 2"
# 6. Annuler les modifications du dernier commit
git reset --hard HEAD^
# 7. Vérifier l’historique (on doit avoir 2 commits)
git log --oneline
# 8. Créer une branche à partir du 1er commit
git checkout 252fa95
git log --oneline
git branch feature
git switch feature
# 9. Faire un commit sur la branche
nano fichier1.txt
git add fichier1.txt
git commit -m "Modification de fichier1"
# 10. Vérifier l’historique de la branche (on doit avoir 2 commits)
git log --oneline
# 11. Lister les branches (on doit avoir 2 branches)
git branch
# 12. Tagger la version
git tag v1.1
# 13. Revenir au sommet de la branche `main`
git switch main
# 14. Lister les tags (on doit avoir un tag)
git tag
# 15. Supprimer la branche
git branch -D feature
# 16. Lister les branches
#     - on doit avoir une seule branche : `main`
git branch
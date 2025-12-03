# Lister les branches (locales)
git branch

# Lister les branches à distances
git branch -r

# Créer une nouvelle branch
git branch <nom_branche> 

# Se déplacer sur une branch
git checkout <nom_branch>
git switch <nom_branch>

# Créer une branch et s'y déplacer 
git checkout -b <nom_branch>
git switch -c <nom_branch>

# Supprimer une branch
git branch -d <nom_branch>

# Fusionner des branch
# Attention la branche cible sera fusionner dans la branche actuelle.
git merge <nom_branch_cible>
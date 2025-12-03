# Pour se déplacer à un commit spécifique.
# Les autres commit ne seront pas supprimé, seule l'affichage du travail local sera dans l'état du commit spécifié.
git checkout <commit_id>

# Pour revenir au dernier commit d'une branche, il suffit de donner le nom de la branche en question
git checkout <branch_name>

# Pour créer un tag sur le commit courant
# Ce tag est léger (ne possede pas de description)
git tag v1.0 

# Pour créer un tag sur un commit spécifique
git tag v1.1 <commit_id>

# Pour donner une description à notre tag
git tag -a <nom_tag> -m <description_tag> 
git tag -a <nom_tag> -m <description_tag> <commit_id> # Pour un commit plus ancien

# Pour afficher les informations d'un tag
git show <nom_tag>
ex: git show v1.0

# Pour se déplacer à un tag spécifique
git checkout <nom_tag>
ex: git checkout v1.0

# Pour supprimer un tag
git tag -d <nom_tag>
ex: git tag -d v1.0 

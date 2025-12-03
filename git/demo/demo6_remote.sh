# Pour démarrer un projet (après avoir créer un repot sur Github)
git init

# Pour ajouter une connection avec un repot distant
git remote add origin <url_depot>

# Pour voir les différentes connexion présente
git remote

# Après modification, nous pouvons transmettre les informations sur le repot distant
git push origin <nom_branch> 

# Pour récupérer les données du depot distant
git fetch origin <nom_branch>
git merge origin/<nom_branch> 

git pull origin main

# Pour récupérer un projet complet
git clone <url_depot>
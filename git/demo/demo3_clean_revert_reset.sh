# clean est utilisé pour supprimer les fichier non-suivies
# l'option -n affiche seulement fichier qui risque d'etre supprimé.
git clean -n 

# Pour supprimer les fichiers non-suivies
git clean -f

# Pour supprimer les fichier et les dossiers non-suivies
git clean -fd

# Pour supprimer les fichiers présent dans le .gitignore
git clean -fx

# Pour annuler un commit sans modifier notre historique (log)
# Nous pouvons utiliser "git revert" avec l'identifiant du commit à inverser.
# Pratique quand on veut revenir en arrière sans supprimer l'historique (sans incidence définitive)
git revert <commit_id>

# Annule toutes les modifications du commit précédent.
git revert HEAD 

# Permet de réinitialiser l'index (staging) et l'arbre de travail au commit spécifié
# Par défaut, reset est en --mixed
# Reviens au commit précédent sans perdre les modifications en locales mais nécessite à ajout puis un commit.
git reset <commit_id>
git reset --mixed <commit_id>

# Permet de réinitialiser jusqu'au commit précédent.
git reset HEAD 

# Reviens au commit précisé sans perdre les modifications locales et est prêt au commit.
git reset --soft <commit_id>

# Reviens au commit spécifié en supprimant toutes les modifications en locales.
# !!!!! Attention car l'historique sera également effacé et il n'y a aucun retour possible.
git reset --hard <commit_id> 




# Version installé
git --version

# Configuration utilisateur
git config --global user.name "Loick"
git config --global user.email "loick@utopios.solutions"

# Retirer toutes les variable de configuration d'un élement
git config --global --unset-all user.name
git config --global --unset-all user.email

# Informations sur les différentes commandes git
git help
git help <nom_commande>

# Voir les informations de configuration
git config --list

# Si la branche par défaut n'est pas main
git config --global init.defaultBranch main


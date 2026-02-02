# TPFinal - Console Blog (C# / .NET 10)


## Description
Petit gestionnaire de blog en console permettant de créer, lister, consulter, modifier et supprimer des articles, ainsi que d'ajouter/supprimer des commentaires. L'entrée du programme se trouve dans `Program.cs` qui appelle `ConsoleMenu.Menu()`.

## Prérequis
- .NET 10 SDK
- C# 14.0
- Visual Studio 2026 (optionnel) ou `dotnet` CLI

## Fichiers principaux
- `Program.cs` — point d'entrée.
- `UI/ConsoleMenu.cs` — menu interactif et logique d'interface utilisateur.
- `UI/ConsoleHelper.cs` — utilitaires d'affichage (en-têtes, erreurs, pause).
- `Services/ArticleService.cs` — opérations CRUD sur les articles.
- (Présence de classes `Article`, `Comment`, et `CommentService` attendue dans le projet.)

## Installation et exécution
1. Ouvrir la solution dans Visual Studio 2026 et lancer le débogage via __F5__ (ou __Debug > Start Debugging__).
2. Ou en CLI depuis le répertoire racine du projet :
   - Restaurer et lancer :
     ```
     dotnet restore
     dotnet run
     ```

3. Si le projet n'est pas un projet racine, préciser le chemin :

    `dotnet run --project ./chemin/vers/Projet.csproj`

## Utilisation
Au lancement, le menu propose les options :
1. Lister les articles  
2. Créer un article  
3. Voir un article (par `id`) — affiche aussi les commentaires  
4. Modifier un article (nécessite l'ID)  
5. Supprimer un article (nécessite l'ID)  
6. Ajouter un commentaire (sur un article par `id`)  
7. Supprimer un commentaire (par `id`)  
0. Quitter

Suivre les invites à l'écran ; les validations de base (entiers non négatifs pour les IDs) sont présentes.

## Limitations connues et améliorations suggérées
- Persistance : données en mémoire (non persistées). Ajouter une couche de stockage (fichier JSON, SQLite) pour conserver les articles entre exécutions.
- Validation utilisateur à renforcer (gestion des entrées vides et exceptions).
- Tests unitaires manquants — ajouter des tests pour `ArticleService` et `CommentService`.
- Internationalisation si besoin (actuellement en français).


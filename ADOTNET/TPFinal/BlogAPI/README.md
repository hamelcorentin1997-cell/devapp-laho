# BlogAPI (TPFinal)

API REST minimaliste pour gérer des articles et leurs commentaires. Projet C# (.NET 10) exposant des endpoints pour créer, lire, modifier et supprimer des articles et commentaires.

## Prérequis
- .NET 10 SDK
- MySQL (accessible depuis la machine de développement)
- Visual Studio 2026 ou __dotnet__ CLI
- (Optionnel) outils EF Core pour migrations : __dotnet-ef__

## Configuration
- Chaîne de connexion (exemple actuel) : dans `Program.cs`
`Server=localhost;Database=blog_db;Uid=root;Pwd=root;Port=3306;`

Ajuster l'hôte, les identifiants et le port selon l'environnement.
- Le projet utilise `Pomelo.EntityFrameworkCore.MySql` via `UseMySql(...)` avec `MySqlServerVersion(new Version(9,0,0))`.

## Lancer l'API
- Depuis Visual Studio 2026 : ouvrir la solution et démarrer en Debug (F5) ou sans Debug.
- Depuis la ligne de commande :
- Restaurer : `dotnet restore`
- Lancer : `__dotnet run__` depuis le répertoire du projet Web API
- Si vous utilisez EF Migrations :
- Créer une migration : `__dotnet ef migrations add Initial__`
- Appliquer la migration : `__dotnet ef database update__`

## Endpoints principaux
Base route :`api/v1`

-Articles (`ArticleController`)
- `GET /api/v1/Article` 
  Paramètres optionnels en query :`id`, `title`, `content`, `creationDate` 
  Retourne la liste des articles (recherche simple /filtrage).
- `GET /api/v1/Article/{id}` 
  Récupère un article avec ses commentaires(inclut `Comments`).
- `POST /api/v1/Article` 
  Création d'un article. Payload attendu : `ArticleCreationRequest` (`Title`, `Content`).
- `PATCH /api/v1/Article/{id}` 
  Modification partielle. Payload : `ArticleModificationRequest`.
- `DELETE /api/v1/Article/{id}` 
  Supprime un article.

- Commentaires (`CommentController`)
- `GET  /api/v1/Comment` 
  Liste tous les commentaires.
- `GET /api/v1/Comment/{id}` 
  Récupère un commentaire par id.
- `POST /api/v1/Comment` 
  Création de commentaire. Payload attendu : `CommentCreationRequest` (`ArticleId`, `Author`, `Content`).
- `DELETE /api/v1/Comment/{id}` 
  Supprime un commentaire.


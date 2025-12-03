# 1. Créer un nouveau repository Git
git init
# 2. Ajouter un fichier `file1` et le commiter `(C1)`
touch file1
git add file1
git commit -m "C1"
# 3. Modifier la première ligne de `file1` et commiter `(C2)`
echo "Modification dans main" > file1
git add .
git commit -m "C2"
# 4. Créer une feature branch `Feature1` à partir de `C1`
git checkout HEAD^
git switch -c Feature1
# 5. Faire une modification de la première ligne de `file1` et commiter `(F1)`
echo "Modifcation de file1 depuis Feature1" > file1
git add .
git commit -m "F1"
# 4. Créer une feature branch `Feature2` à partir de `C1`
git checkout HEAD^
git checkout -b Feature2
# 5. Faire une modification de la première ligne de `file1` et commiter `(F2)`
echo "Modification de file1 depuis Feature2" > file1
git add .
git commit -m "F2"
# 6. Merger `Feature1` dans `main` en résolvant les conflits
git switch main
git merge Feature1
nano file1
git add .
git commit -m "C3"
# 6. Merger `Feature2` dans `main` en résolvant les conflits
git merge Feature2
nano file1
git add .
git commit -m "C4"
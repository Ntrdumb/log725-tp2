# Moon Tank - Prototype TP2

## Introduction

Dans le cadre du TP2, il a été chargé de développer un prototype jouable à partir du GDD de **Moon Tank**. Ce projet s’inscrit dans le contexte du développement de jeux vidéo en suivant un document de conception de jeu, qui définit les lignes directrices concernant les aspects de gameplay, de conception visuelle, et de logique technique du jeu. L’objectif principal est de créer un niveau jouable en implémentant certains éléments clés du gameplay décrits dans le GDD.

Voici le lien du répertoire : [Moon Tank Repo](https://github.com/Ntrdumb/log725-tp2)

## Développement

Plusieurs modules ont été ajoutés pour implémenter les mécaniques de jeu de **Moon Tank**. Ces modules incluent la gestion des munitions, des collisions, des tirs du joueur, ainsi que la gestion des sons. Ils ont été développés en utilisant des patrons de conception tels que le **Singleton**, le **Component**, et l'**Observer Pattern**.

### 1. ShootingScript (Gestion du Tir)

Le script `ShootingScript` permet au joueur de tirer trois types de munitions (rouge, verte, bleue) en appuyant sur les touches Z, X et C. Il vérifie si le joueur dispose de suffisamment de munitions via le **AmmoHandler** et joue le son correspondant grâce à l'**AudioManager**. Ce module suit le **Component Pattern**.

### 2. bulletCollision (Gestion des Collisions)

Le script `bulletCollision` gère les collisions entre les projectiles et les obstacles. Les projectiles détruisent les obstacles de la même couleur, et les objets sont supprimés après collision pour éviter une surcharge en mémoire. Ce module suit également le **Component Pattern**.

### 3. AmmoHandler (Gestion des Munitions)

Le script `AmmoHandler` gère la quantité de munitions pour chaque type (rouge, verte, bleue) et met à jour l'interface utilisateur en temps réel. Il repose sur le **Singleton Pattern** pour la gestion d'une seule instance et sur l'**Observer Pattern** pour mettre à jour l'UI.

### 4. AudioManager (Gestion des Sons)

Le module `AudioManager` centralise la gestion des sons du jeu, incluant les effets des tirs et la musique de fond. Il permet également de muter les sons via l'interface utilisateur. Il utilise le **Singleton Pattern** pour garantir une instance unique tout au long du jeu.

### 5. MouvementJoueur (Gestion des Mouvements)

Le script `MouvementJoueur` gère les déplacements du joueur, en ajustant la direction selon ses mouvements. Ce module suit le **Component Pattern** pour isoler les différentes fonctionnalités du mouvement.

### 6. MainMenuController (Gestion du Menu Principal)

Le script `MainMenuController` permet au joueur de démarrer une nouvelle partie, de quitter le jeu ou de redémarrer une partie. Il interagit avec l'**AudioManager** pour arrêter la musique lors du retour au menu principal. Ce module combine le **Singleton Pattern** et le **Component Pattern** pour une gestion modulaire.

### 7. AmmoPickup (Ramassage de Munitions)

Le script `AmmoPickup` gère l'interaction entre le joueur et les munitions dans le jeu. Lorsqu'un joueur collecte une munition (rouge, verte ou bleue), elle est ajoutée à l'inventaire et l'objet est détruit pour éviter un double ramassage.

## Suggestion d'Amélioration

Une suggestion pour enrichir le gameplay serait d’ajouter des **obstacles mobiles** dans les niveaux. Ces obstacles suivraient des trajectoires linéaires ou circulaires, ajoutant ainsi une dimension supplémentaire de stratégie où le joueur doit anticiper leurs mouvements pour éviter d’être bloqué. Certains obstacles pourraient être destructibles, tandis que d'autres seraient indestructibles, augmentant la complexité et la variété des niveaux.

## Bibliographie

- [Gun Sounds](https://opengameart.org/content/collection-gun-sounds)
- [Laser Fire](https://opengameart.org/content/laser-fire)
- [Laser Rifle](https://opengameart.org/content/laser-rifle)
- [Red Doors v2.0](https://opengameart.org/content/red-doors-v20)
- [Type 97 Image](https://static.wikia.nocookie.net/callofduty/images/9/9d/Type_97_CoD_WaW.jpg/revision/latest?cb=20120306222939)

# WebServices - Enigma - API/CLIENT
Le présent document décrit le fonctionnement attendu pour le projet de WebServices. Le document décrit un certain nombre d'éléments techniques à satisfaire, comme les noms de routes, le format de certains éléments des requêtes ou encore nom de certaines variables. Mais encore comment faire fonctionner le projet, les étapes à suivre pour la mise en fonction de l'application.
* **Le projet est dirigé par Sorelli Julien et Patalano Jonathan**

## Prérequis et installation :
- [Installation Node-JS + npm](https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com%2F)
- [Installation Visual Studio 2019](https://nodejs.org/fr/)
- [Installation Visual Studio Code](https://code.visualstudio.com/) - (ou tout autre IDE)

## Configuration et mise en fonction :
- Ouvrir la solution WebApi sur Visual Studio 2019, lancer l'application WebApi.
- Une fois effectuer une fenetre d'application s'ouvre, ne pas la fermer.
- Ouvrir la solution WebServices sur l'IDE de votre choix.
- Ouvrir un terminal et installez tous les paquets npm requis en exécutant **npm install** depuis la ligne de commande dans le dossier racine du projet (où se trouve le package.json).
- Démarrez l'application en exécutant **ng serve --open** depuis la ligne de commande dans le dossier racine du projet.
- Votre navigateur devrait s'ouvrir automatiquement sur **http://localhost:4200** avec la page de connexion.
- Se connecter avec l'utilisateur suivant : Identifiant : **jopatalano** Mot de passe : **azerty**

# WebServices - Enigma - Serveur Applicatif

Ce dépôt contient le serveur applicatif du projet Enigma de la majeure WebServices.
Ce serveur est développé en php, autour du framework Laravel.

## Prérequis et installation

- **[Installation Composer](https://getcomposer.org/download/)** 
- **[Installation PHP](https://www.php.net/manual/fr/install.php)**
- **[Installation Visual Studio Code](https://code.visualstudio.com/download) - (ou tout autre IDE)**


## Configuration

- **Ouvrir la solution sur un IDE (ici Visual Studio Code)** 
- **Exécuter la commande "composer install"**
- **Exécuter la commande "php serverwebsocket.php"**
- **Exécuter  dans une deuxième console la commande "php artisan serve"**


## Architecture et documentation 

- **[Laravel](https://laravel.com/)** 
- **[Ratchet](http://socketo.me/)**
- **[JWT-Auth](https://github.com/tymondesigns/jwt-auth)**


## Base de données  

-**MySQL**
- **Hôte : enigma.ct9iqvkrmtjz.eu-west-3.rds.amazonaws.com**
- **Utilisateur : admin**
- **Password : rootroot**
- **Port : 3306** 


## Mieux comprendre le sujet (Rappel) :
La finalité du projet est de tenter de bruteforcer des messages chiffrés dont on ne connait pas la clé privée. Le projet est donc composé en plusieurs partis :
* Une application serveur qui fournit des tokens d'authentification (lorsqu'on lui fournit des paires login/pass valides) on parle d'une autorité de certification (CA donc ou AS souvent Authorization Serveur).
* Une autre application serveur, dans un autre langage, qui va vérifier que les requêtes qu'il reçoit sont bien signées via ce token avant de fournir des éléments pour le brute force. On parle ici de notre application serveur. Ce serveur va servir à orchestrer le travai de brute force et il ne va pas lui même tenter de décrypter (ou déchiffrer par un moyen inpropre) quoi que ce soit mais simplement charger chaque client qui s'y connectera de faire une partie du travail.
* Une application client qui va permettre de s'authentifier auprès du premier serveur (et stocker le token en mémoire) demander au serveur de lui fournir un morceau de code qu'il pourra exécuter pour tenter de bruteforcer les messages demander au serveur un batch à tenter, composée de : un message chiffré, une clé à partir de laquelle on doit tenter de déchiffrer, une clé à laquelle on doit arrêter. On parlera de batch pour identifier ce trinome, c'est plus simple à comprendre le client tente ensuite de casser le code avec l'algorithme que le serveur lui a fourni et pour un batch donné, puis : si cela a fonctionné, il en informe le serveur avec la combinaison qui a fonctionné et le message envoyé en clair si cela a échoué, il en informe le serveur qui va pouvoir rayer ce batch de la liste des tests à effectuer

## Architecture et documentation :

La première étapes de nos travaux fut l'appréhension du sujet, et le rassemblement des compétences au sein de notre équipe. Aprés avoir établis la liste des languages et des différents outils que nous allions utiliser durant ce projet, nous avons établis au clair sur papier différents schéma d'applications et décris le fonctionnement des différentes solutions au sein du projet.

Dans un premier temps nous avons opté pour une solution .Net Core 3.0 côté API car ayant pour habitude de travailler en entreprise avec le langage C# en Asp.Net, nous trouvions intéressant d’étudier les dernières façons de concevoir des applications à la manière Microsoft.

Côté application client nous opterons pour un frontend en Angular 7 CLI, pour une implementation simple et efficace.

Enfin au niveau application serveur nous opterons pour du Laravel, qui va nous permettre de créer une application serveur plus rapidement et surtout plus facilement.

## Difficultés rencontrées :

* Manque d'expérience dans l'architecture de solutions avec utilisation de web socket ou de webservices.
* Manque d'organisation en amont du projet sur la création de documentation de conception.

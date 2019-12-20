# WebServices
Le présent document décrit le fonctionnement attendu pour le projet de WebServices. Le document décrit un certain nombre d'éléments techniques à satisfaire, comme les noms de routes, le format de certains éléments des requêtes ou encore nom de certaines variables. Mais encore 

## Prérequis et installation :
- [Installation Node-JS + npm](https://visualstudio.microsoft.com/fr/downloads/?rr=https%3A%2F%2Fwww.google.com%2F)
- [Installation Visual Studio 2019](https://nodejs.org/fr/)

## Configuration et mise en fonction :
- Ouvrir la solution WebApi sur Visual Studio 2019, lancer l'application WebApi.
- Une fois effectuer une fenetre d'application s'ouvre, ne pas la fermer.
- Ouvrir la solution WebServices sur l'IDE de votre choix.
- Ouvrir un terminal et éxecuter la commande suivante **Installez tous les paquets npm requis en exécutant npm install depuis la ligne de commande dans le dossier racine du projet (où se trouve le package.json). **
- Démarrez l'application en exécutant **ng serve --open** depuis la ligne de commande dans le dossier racine du projet.

## Mieux comprendre le sujet :
Tout d’abord mon travail commença par la lecture des documents fournit : introduction type prise en main et le premier TP étant la création d’un calendrier. Et par la rédaction sur papier des points les plus importants du travail demandé. Ainsi j’ai schématisé d’autre part L’API pour me donner une idée du travail à réaliser derrière.

## Architecture et documentation :

Une fois le sujet appréhender j’ai comparé plusieurs langages de programmation (JS Ajax, React, .Net) et les différentes façons de créer des API en fonction de ce choix.
J’ai finalement opté pour une solution .Net Core 3.0 car ayant pour l’habitude de travailler en entreprise avec le langage C# en Asp.Net, je trouver intéressant d’étudier les dernières façons de concevoir des applications à la manière Microsoft.
A savoir donc que je n’ai jamais utiliser .Net Core et ses outils.

## Implémentation :

J’ai commencé par installer Visual studio 2019, et débuter par me familiariser avec la création d’applications en .Net Core.
Après m’être documenter sur différentes sources j’ai suivis ce tutoriel https://docs.microsoft.com/fr-fr/aspnet/core/tutorials/first-web-api?view=aspnetcore-3.0&tabs=visual-studio disponible sur la documentation officiel de Microsoft.
J’ai rencontré quelques problèmes surtout niveau base de données durant l’implémentation qui m’ont valu de recommencer plusieurs fois. Une fois finis j’ai donc obtenu une API fonctionnel cependant ne possédant qu’une seule entité étant des utilisateurs.
Suite à la mise en place de la première API j’ai décidé de suivre plusieurs tuto expliquant le fonctionnement de JWT, après avoir lu celui étant fournit sur Moodle j’ai décidé de suivre le suivant : https://www.grafikart.fr/tutoriels/json-web-token-presentation-958 expliquant d’une part le concept et d’autre l’implémentation.

Suite à cela j’ai repris d’une part le projet API et essayer d’implémenter le JWT en respectant ce qui avait déjà était accompli cependant je n’ai pas réussis à l’implémenter correctement, ce n’est qu’avec l’aide de cet article : https://jasonwatmore.com/post/2019/10/11/aspnet-core-3-jwt-authentication-tutorial-with-example-api#extension-methods-cs que j’ai pu implémenter le JWT, cependant il me reste encore quelques points à corriger pour que le fonctionnement soit parfait.

J’ai commencé à rédigé sur papier un schéma concernant la mise en place d’une autorité de certification, d’un serveur applicatif et de l’utilisation de clients applicatifs pendant les dernières séances avant  de me lancer dans son implémentation.

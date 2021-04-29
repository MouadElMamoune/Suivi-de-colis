# Suivi-de-colis
Cahier de charge de l'application de suivi des colis dans une société de transport
L'application sera réalisée avec la technologie .NET du langage C# ainsi qu'avec le langage de requêtes CYPHER QUERY LANGUAGE associé à NEO4J.
1) L'application est verrouillée tant qu'un mot de passe n'a pas été entré.
2) Un compteur de mots de passe erronés doit être mis en place avec une réinitialisation à chaque connexion.
3)  Au bout de dix mots de passe erronés, l'accès doit être bloqué pour une durée de 2 minutes.
4) Une fois que la connexion a été faite, la fenêtre d'accueil s'affichera.
5) La fenêtre d'accueil comporte quatre boutons.
6) Le premier bouton est nommé "Gestion", le second est nommé "Planification de livraison", le troisième est nommé "Suivi actuel" et le dernier est nommé "Statistiques".
7) Le bouton "Gestion"  conduit à son tour à une nouvelle fenêtre avec cinq boutons.
8) Le premier bouton est nommé "Gestion des camions" où il sera possible d'ajouter, de supprimer, de modifier des camions ou les informations les concernant. 
9) Le second  bouton est nommé "Gestion des chauffeurs" où il sera possible d'ajouter, de supprimer, de modifier des chauffeurs ou les informations le concernant.
10) Le troisième bouton est nommé "Gestion des colis" où il sera possible d'ajouter, de supprimer, de modifier des chauffeurs ou les informations le concernant.
10) Le quatrième bouton est nommé "Gestion des destinations" où il sera possible d'ajouter, de supprimer, de modifier des destinations ou les informations les concernant.
10) Le cinquième bouton est nommé "Gestion des clients" où il sera possible d'ajouter, de supprimer, de modifier des destinations ou les informations les concernant.
11) Un ajout peut se faire manuellement ou par importation d'un fichier csv.
12) Avant que l'importation ne se fasse, une fenêtre s'affichera où l'utilisateur aura le choix d'écraser les informations existantes ou non.
13) Un camion est caractérisé par son identifiant unique,  sa matricule, sa marque, son modèle, son poids, sa consommation en litre par kilomètre, la longueur de sa caisse en mètre, la hauteur de sa caisse en mètre et la largeur de sa caisse en mètre, le poids maximal de sa cargaison.
14) Un chauffeur est caractérisé par un identifiant unique, son nom, son prénom, sa date d'embauche, son salaire et sa note.
15) Un colis est caractérisé par son identifiant unique,  sa longueur en mètre, sa hauteur en mètre, sa largeur en mètre, sa fragilité.

16) Un colis fragile signifie qu'il ne peut y avoir de colis au-dessus.
17) Une destination est caractérisée par son identifiant unique, son adresse postale et ses coordonnées GPS. 
18) Un client est caractérisé par son identifiant unique, nom (de personne ou d'entreprise) et le nombre de livraisons réalisées pour son compte.
19)  Un camion est affecté au maximum à un seul chauffeur.
20) Un camion qui ne possède pas de chauffeur ne peut pas réaliser de livraison.
21) Un ou plusieurs colis peuvent être affectés à un camion.
22) Un camion dont la capacité a été excédée ne peut pas réaliser de livraison.
23) Le bouton "Planification de livraison" conduit à une fenêtre avec un formulaire.
24) L'utilisateur sélectionne un camion qui doit être disponible.
25) L'utilisateur sélectionne la destination de chargement du camion.
26) L'utilisateur sélectionne les colis à charger dans le camion.
27) L'utilisateur choisit le nombre de destinations.
28) L'utilisateur sélectionne les destinations et à chaque destination il affecte les colis à décharger.
29) L'utilisateur valide la livraison.
30) Le passage d'une destination à une autre est appelé déplacement.
31) Un déplacement est caractérisé par son identifiant unique, sa date de départ et sa date d'arrivée.
32) La date doit être sous format "dd/mm/yyyy hh:mm".
33) Une livraison est considérée comme étant en cours tant que la date d'arrivée d'un déplacement n'a pas été renseignée.
34) Le bouton "Suivi actuel" conduit à un fenêtre où on peut visualiser le trajet des livraisons en cours.
35) À côté de chaque destination, il y a un bouton "Valider".
36) La validation d'une destination signifie que le camion y a chargé/déchargé les colis la concernant.
37) Après avoir cliqué sur le bouton "Valider", une fenêtre invitera l'utilisateur à renseigner la date d'arrivée.
37) Le bouton "Statistiques" conduit à une fenêtre où l'utilisateur peut visualiser différentes statistiques. (À continuer)



 



 

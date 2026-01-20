
CREATE TABLE clients(
clientId INT AUTO_INCREMENT PRIMARY KEY,
nom VARCHAR(150) NOT NULL,
prenom VARCHAR(150) NOT NULL,
adresse VARCHAR(200) NOT NULL,
codePostal VARCHAR(50) NOT NULL,
ville VARCHAR(100),
numeroTelephone VARCHAR(50) NOT NULL UNIQUE
);



CREATE TABLE commandes(
CommandeId INT AUTO_INCREMENT PRIMARY KEY,
clientId INT NOT NULL,
dateCommande date,
total double ,
CONSTRAINT fk_clientId FOREIGN KEY (clientId) REFERENCES clients(clientId)
);
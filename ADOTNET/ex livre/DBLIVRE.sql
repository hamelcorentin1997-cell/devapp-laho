CREATE DATABASE IF NOT EXISTS db_Livres;
USE db_Livres;

CREATE TABLE Livres 
(
id INT PRIMARY KEY auto_increment,
title VARCHAR(150) UNIQUE,
author VARCHAR(150),
publishingYear INT,
isbn VARCHAR(50) UNIQUE
) 

CREATE DATABASE Atividade1;
GO

USE Atividade1;
GO

-- Primeiro criando as tabelas que s� tem as PK's
CREATE TABLE Clinica (

	IdClinica INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR (30) NOT NULL,
	Endereco VARCHAR (100) NOT NULL,

);
GO

CREATE TABLE Dono (

	IdDono INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR (50) NOT NULL,

);
GO

CREATE TABLE Raca (

	IdRaca INT PRIMARY KEY IDENTITY NOT NULL,
	Raca VARCHAR (20) NOT NULL,

);

--Tabelas com FK's agora
CREATE TABLE Veterinario (

	IdVeterinario INT PRIMARY KEY IDENTITY NOT NULL,
	IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica), --FK
	Nome VARCHAR (50) NOT NULL,
	CRV VARCHAR (15) NOT NULL,
	
);

CREATE TABLE Pet (

	IdPet  INT PRIMARY KEY IDENTITY NOT NULL,
	Nome VARCHAR (20) NOT NULL,
	IdDono INT FOREIGN KEY REFERENCES Dono(IdDono), --FK
	IdRaca INT FOREIGN KEY REFERENCES Raca(IdRaca), --FK

);

CREATE TABLE Atendimento (

	IdAtendimento INT PRIMARY KEY IDENTITY NOT NULL,
	Descricao VARCHAR (100),
	IdVeterinario INT FOREIGN KEY REFERENCES Veterinario(IdVeterinario),
	IdDono INT FOREIGN KEY REFERENCES Dono(IdDono),


);


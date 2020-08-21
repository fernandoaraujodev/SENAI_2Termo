USE Nyous;
Go

-- Somente as PK's
INSERT INTO Acesso (Tipo) VALUES
	('Administrador'),
	('Padrao');


INSERT INTO Categoria (Titulo) VALUES
	('Meetup'),
	('Workshop'),
	('Black Hat'),
	('Live'),
	('Palestra');

INSERT INTO LOCALIZACAO (Logradouro, Numero, Bairro, Cidade, UF, CEP) VALUES
	('Alameda Barão de Limeira', 539, 'Santa Cecília', 'São Paulo', 'SP', '01202-001'),
	('Rua Brasilis', 433, 'Jardim Canhema', 'Diadema', 'SP', '09788-560');

-- Com as FK's
INSERT INTO Usuario (Nome, Email, Senha, DataNascimento, IdAcesso) VALUES
	('Fernando Araujo', 'fearaujo@yahoo.com.br', 'senha132', '2003-10-23T09:43:00', 1),
	('Paulo Brandao', 'paulo@senai.br', '123456789', '1990-04-02T05:20:00', 2);

INSERT INTO Evento (DataEvento, Capacidade, AcessoRestrito, IdCategoria, IdLocalizacao) VALUES
	('2020-10-15T22:00:00', 100, 0, 3, 1),
	('2020-08-23T16:00:00', 22, 0, 4, 2);
USE Edux;

INSERT INTO Usuario (Email, Senha) VALUES ('joaovitosantossouza7@gmail.com', 'senha123'); 

INSERT INTO Usuario (Email, Senha) VALUES ('Antonio@gmail.com', '123senha');

INSERT INTO Categoria (TipoCategoria) VALUES ('Desejavel'),('Critico'),('Oculto'); 

INSERT INTO Turma (Serie) VALUES ('2ºC'),('1ºB'),('3ºA'); 

INSERT INTO Aluno (Nome, RM, DataNascimento, RG, IdUsuario, IdTurma) 
VALUES ('Joao', '731897484', '2000-09-15', '10', 1, 2);

INSERT INTO Professor (Nome, RM, DataNascimento, RG, UF, Logradouro, Cidade, Complemento, Bairro, Numero, IdUsuario) 
VALUES ('Antonio', '748314789', '2000-04-21', '1054780249','SP', 'Avenida Paranapanema', 'Diadema', '', 'Jardim Sao Judas', '1343', 2);

INSERT INTO Dicas (TextoDica, IdProfessor) VALUES ('Lorem Ipsum', 1);

INSERT INTO Post (Texto, Imagem, Turma, Aluno) VALUES ('Lorem Ipsum', 'encurtador.com.br/wORU5', 2, 2);

INSERT INTO Disciplina (Nome, ConteudoProg) VALUES
('Desenvolvimento de Sistemas', 'fheuwhuohov');

INSERT INTO Objetivo (Descricao, Professor, Categoria, Disciplina) VALUES ('Lorem Ipsum', 1, 1, 1);

INSERT INTO Aluno_Obj (Nota, DataEntrega, Objetivo, Aluno) VALUES (70, '2000-06-18T00:20:00', 1, 2);

INSERT INTO Professor_Turma (Professor, Turma) VALUES (1, 2);


SELECT * FROM Professor_Turma;
SELECT * FROM Aluno_Obj 
SELECT * FROM Objetivo;
SELECT * FROM Disciplina;
SELECT * FROM Post;
SELECT * FROM Dicas;
SELECT * FROM Professor;
SELECT * FROM Aluno;
SELECT * FROM Usuario;
SELECT * FROM Categoria;
SELECT * FROM Turma;

UPDATE Aluno SET  
RG = '6429671232'
WHERE IdAluno = 2
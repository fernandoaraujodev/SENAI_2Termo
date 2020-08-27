USE Edux;

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

SELECT
Aluno.RM,
Aluno.Nome,
Aluno_Obj.Nota,
Aluno_Obj.DataEntrega
FROM Aluno_Obj
RIGHT JOIN Objetivo ON Aluno_Obj.Objetivo = Objetivo.IdObjetivo
INNER JOIN Aluno ON Aluno.IdAluno = Aluno_Obj.Aluno;


SELECT * FROM Professor_Turma
INNER JOIN Professor  ON Professor_Turma.Professor = Professor.IdProfessor
INNER JOIN Turma ON Turma.IdTurma = Professor_Turma.Turma;


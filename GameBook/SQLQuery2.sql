USE Game
GO

-- INSERTS

CREATE PROCEDURE InserirJogo (@NomeJogo NVARCHAR(80), @HorasJogadas INT = 0, @Lancamento NVARCHAR(4), 
                              @IdGenero INT, @IdPlataforma INT, @IdAvaliacao INT)
AS
INSERT INTO Jogos (Nome_Jogo, Horas_Jogadas, Ano_Lancamento, ID_Genero, ID_Plataforma, ID_Avaliacao)
VALUES (@NomeJogo, @HorasJogadas, @Lancamento, @IdGenero, @IdPlataforma, @IdAvaliacao)
GO

EXEC InserirJogo'Minecraft', 120, 2006, 1, 1, 10
GO

EXEC InserirJogo'Stardew Valley', 300, 2002, 1, 1, 10
GO

CREATE PROCEDURE InserirGenero (@NomeGenero NVARCHAR(50))
AS
INSERT INTO Generos(Nome_Genero)
VALUES (@NomeGenero)
GO

EXEC InserirGenero 'Terror'
GO

CREATE PROCEDURE InserirPlataforma (@NomePlataforma NVARCHAR(50))
AS
INSERT INTO Plataformas(Nome_Plataforma)
VALUES (@NomePlataforma)
GO

EXEC InserirPlataforma 'Steam'
GO

SELECT * FROM Jogos
GO

SELECT A.Descricao
FROM Avaliacoes AS A
INNER JOIN Jogos AS J
ON J.ID_Avaliacao = A.ID_Avaliacao
GO

-- UPDATES

CREATE PROCEDURE AlterarJogo (@NomeAlt NVARCHAR(80), @NomeJogo NVARCHAR(80), @HorasJogadas INT = 0, @Lancamento NVARCHAR(4), 
                              @IdGenero INT, @IdPlataforma INT, @IdAvaliacao INT)
AS
UPDATE Jogos 
SET Nome_Jogo = @NomeJogo, Horas_Jogadas = @HorasJogadas, Ano_Lancamento = @Lancamento,
                ID_Genero = @IdGenero, ID_Plataforma = @IdPlataforma, ID_Avaliacao = @IdAvaliacao
WHERE Nome_Jogo = @NomeAlt
GO

CREATE PROCEDURE AlterarGenero (@NomeAltGen NVARCHAR(50), @NomeGenero NVARCHAR(50))
AS
UPDATE Generos
SET Nome_Genero = @NomeAltGen 
WHERE Nome_Genero = @NomeAltGen
GO

CREATE PROCEDURE AlterarPlataforma (@NomeAltPla NVARCHAR(50), @NomeGenero NVARCHAR(50))
AS
UPDATE Plataformas
SET Nome_Plataforma = @NomeAltPla
WHERE Nome_Plataforma = @NomeAltPla
GO

-- DELETES

CREATE PROCEDURE ExcluirJogo (@NomeJogoEx NVARCHAR(80))
AS
DELETE FROM Jogos
WHERE Nome_Jogo = @NomeJogoEx
GO

EXEC ExcluirJogo 'Stardew Valley'
GO

CREATE TRIGGER Backup_Jogos
ON Jogos
AFTER DELETE
AS
INSERT INTO BackupJogos (ID_Jogo, Nome_Jogo, Horas_Jogadas, Ano_Lancamento, ID_Genero, ID_Plataforma, ID_Avaliacao, Data_Operacao)
SELECT D.ID_Jogo, D.Nome_Jogo, D.Horas_Jogadas, D.Ano_Lancamento, D.ID_Genero, D.ID_Plataforma, D.ID_Avaliacao, GETDATE()
FROM deleted AS D
GO

CREATE TABLE BackupJogos (
ID_Jogo INT,
Nome_Jogo NVARCHAR(80),
Horas_Jogadas INT,
Ano_Lancamento NVARCHAR(4),
ID_Genero INT,
ID_Plataforma INT,
ID_Avaliacao INT,
Data_Operacao DATE DEFAULT GETDATE()
);
GO

SELECT * FROM BackupJogos
GO


CREATE PROCEDURE ExcluirGenero (@NomeGenEx NVARCHAR(50))
AS
DELETE FROM Generos
WHERE Nome_Genero = @NomeGenEx
GO

CREATE PROCEDURE ExcluirPlataforma (@NomePlatEx NVARCHAR(50))
AS
DELETE FROM Plataformas
WHERE Nome_Plataforma = @NomePlatEx
GO

-- PROCERURES

--Adicionar mais horas jogadas
CREATE PROCEDURE AdicionarHoras (@NomeJogo NVARCHAR(80), @Horas INT)
AS
BEGIN
	DECLARE @JogoSomar NVARCHAR(80)
	DECLARE @HorasExistentes INT
	DECLARE @HorasAtualizadas INT
	SET @JogoSomar = @NomeJogo

	SELECT @HorasExistentes = jogos.Horas_Jogadas
	FROM Jogos
	WHERE Jogos.Nome_Jogo = @JogoSomar

	SET @HorasAtualizadas = @HorasExistentes + @Horas

	UPDATE Jogos
	SET Horas_Jogadas = @HorasAtualizadas 
	WHERE Nome_Jogo = @NomeJogo
END
GO

EXEC AdicionarHoras 'Minecraft', 20
GO

-- FUNCTIONS 

-- Total de horas jogadas de todos os jogos
CREATE FUNCTION SomaTotalHorasJogadas()
RETURNS INT
AS
BEGIN
    DECLARE @TotalHoras INT

    SELECT @TotalHoras = SUM(Horas_Jogadas)
    FROM Jogos

    RETURN @TotalHoras
END
GO

DECLARE @HorasJogadas INT;
SET @HorasJogadas = dbo.SomaTotalHorasJogadas();
SELECT @HorasJogadas AS Total_Horas_Jogadas;

-- SELECT

SELECT J.Nome_Jogo, J.Horas_Jogadas, J.Ano_Lancamento, J.ID_Genero, J.ID_Plataforma, J.ID_Avaliacao
FROM Jogos AS J
INNER JOIN Generos ON Generos.ID_Genero = J.ID_Genero
INNER JOIN Plataformas ON Plataformas.ID_Plataforma = J.ID_Plataforma
INNER JOIN Avaliacoes ON Avaliacoes.ID_Avaliacao = J.ID_Avaliacao
AND J.Nome_Jogo = 'Minecraft'
GO

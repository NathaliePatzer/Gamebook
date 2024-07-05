CREATE DATABASE Game
GO

USE Game
GO

CREATE TABLE Generos (
ID_Genero INT IDENTITY (1,1),
Nome_Genero NVARCHAR(50) NOT NULL,
CONSTRAINT PK_GENEROS PRIMARY KEY (ID_Genero)
);
GO

CREATE TABLE Plataformas (
ID_Plataforma INT IDENTITY (1,1),
Nome_Plataforma NVARCHAR(50) NOT NULL,
CONSTRAINT PK_PLATAFORMAS PRIMARY KEY (ID_Plataforma)
);
GO

CREATE TABLE Avaliacoes (
ID_Avaliacao INT IDENTITY(1,1),
Descricao NVARCHAR(50) NOT NULL,
CONSTRAINT PK_AVALIACOES PRIMARY KEY (ID_Avaliacao)
);
GO

CREATE TABLE Jogos (
ID_Jogo INT IDENTITY (1,1),
Nome_Jogo NVARCHAR(80) CONSTRAINT UQ_TITULO UNIQUE NOT NULL,
Horas_Jogadas INT NOT NULL,
Ano_Lancamento NVARCHAR(4) NOT NULL,
ID_Genero INT NOT NULL,
ID_Plataforma INT NOT NULL,
ID_Avaliacao INT NOT NULL,
CONSTRAINT PK_Jogo PRIMARY KEY (ID_Jogo),
CONSTRAINT FK_Jogo_Genero FOREIGN KEY (Id_Genero) REFERENCES Generos (ID_Genero),
CONSTRAINT FK_Jogo_Plataforma FOREIGN KEY (ID_Plataforma) REFERENCES Plataformas (ID_Plataforma),
CONSTRAINT FK_Jogo_Avaliacao FOREIGN KEY (ID_Avaliacao) REFERENCES Avaliacoes (ID_Avaliacao)
);
GO

INSERT INTO Avaliacoes (Descricao)
VALUES ('0.5 - Horrível'),
	   (' 1  - Muito Ruim'),
	   ('1.5 - Ruim'),
	   (' 2  - Fraco'),
	   ('2.5 - Regular'),
	   (' 3  - Legal'),
	   ('3.5 - Bom'),
	   (' 4  - Muito Bom'),
	   ('4.5 - Ótimo'),
	   (' 5  - Obra-Prima')
GO

INSERT INTO Avaliacoes (Descricao)
VALUES ('0.5 - Teste')
GO
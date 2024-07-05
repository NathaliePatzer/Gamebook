USE Game
GO

-- Pesquisar Jogos por Nome

CREATE FUNCTION PesquisarJogosPorNome (@NomeJogo NVARCHAR(80))
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Jogos
    WHERE Nome_Jogo LIKE '%' + @NomeJogo + '%'
);
GO

SELECT *
FROM dbo.PesquisarJogosPorNome('aft');
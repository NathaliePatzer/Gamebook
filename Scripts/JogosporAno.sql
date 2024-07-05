USE Game
GO

-- Pesquisar Jogos por Ano

CREATE FUNCTION PesquisarJogosPorAno (@Ano NVARCHAR(4))
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Jogos
    WHERE Ano_Lancamento = @Ano
);
GO

SELECT *
FROM dbo.PesquisarJogosPorAno('2005');
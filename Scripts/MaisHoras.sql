USE Game
GO

-- Jogo com mais horas jogadas

CREATE FUNCTION JogoComMaisHorasJogadas()
RETURNS NVARCHAR(80)
AS
BEGIN
    DECLARE @NomeJogo NVARCHAR(80);

    SELECT TOP 1 @NomeJogo = Nome_Jogo
    FROM Jogos
    ORDER BY Horas_Jogadas DESC;

    RETURN @NomeJogo;
END;
GO

DECLARE @JogoComMaisHoras NVARCHAR(80);
SET @JogoComMaisHoras = dbo.JogoComMaisHorasJogadas();
SELECT @JogoComMaisHoras AS Jogo_Com_Mais_Horas_Jogadas;


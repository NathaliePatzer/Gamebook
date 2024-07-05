USE Game
GO

-- Horas jogadas por jogo

CREATE FUNCTION TotalHorasPorJogo (@NomeJogo NVARCHAR(80))
RETURNS INT
AS
BEGIN
    DECLARE @TotalHoras INT;

    SELECT @TotalHoras = SUM(Horas_Jogadas)
    FROM Jogos
    WHERE Nome_Jogo = @NomeJogo;

    RETURN @TotalHoras;
END;
GO

DECLARE @HorasJogadas INT;
SET @HorasJogadas = dbo.TotalHorasPorJogo('Mine');
SELECT @HorasJogadas AS Total_Horas_Jogadas;
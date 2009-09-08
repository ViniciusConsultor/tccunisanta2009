set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_busca_maxEstoque]
AS
SELECT MAX(id_estoque) as id_estoque
FROM Estoque

USE [ITI]
GO
/****** Object:  UserDefinedFunction [dbo].[GetValuesBetween]    Script Date: 12/5/2024 4:19:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER FUNCTION [dbo].[GetValuesBetween](@START INT , @END INT)
RETURNS @ResultTable   TABLE (VALUE INT)
AS
BEGIN
	DECLARE @INDEX INT = @START;
	WHILE @INDEX <= @END
		BEGIN
			INSERT INTO @ResultTable (VALUE) VALUES (@INDEX);
			SET @INDEX = @INDEX + 1;
		END
	RETURN;
END;